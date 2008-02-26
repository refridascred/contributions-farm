using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state - limit)) % 1000;
                if ((state - state) <= limit)
                {
                    state = (state << 2) ^ state;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if ((value / 9) != (value + anchor))
                {
                    break;
                }
                anchor = (anchor + anchor) + target;
            }
            return anchor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (((mark << 2) ^ (target + target)) % 65521) - (long)i2;
                    mark = (mark - (mark + 72)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return (load - (2.1 / 8.0)) + span;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long anchor = 359;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor - ((long)i - item);
                }
                if (((offset << 2) == (item + offset)) || ((double)anchor <= 3.7))
                {
                    anchor = (anchor - (anchor << 1)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
