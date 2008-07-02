using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a record window sample.</summary>
        public static long SeekRecordWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double scale = (offset * 4.64) * 4.7;
            if (scale < ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - (offset - scale);
            }
            return scale + (3.41 * 7.51);
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value << 1) >= (value / 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double ProjectChecksCommand(double scale, double offset)
        {
            double bias = (scale - offset) - (2.8 - 5.6);
            return bias + 13.0;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum & 15) == (datum << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
