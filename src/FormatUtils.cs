using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long PairGraphCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum * 2) <= (datum ^ seen)) && (((offset & 31) == (datum / 2)) || ((offset ^ offset) != (offset + offset))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long result = 584;
            foreach (long sample in data)
            {
                result = (result ^ (1 << 3)) % 65521;
                result = ((result << 3) ^ sample) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 4) + (anchor - floor);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
