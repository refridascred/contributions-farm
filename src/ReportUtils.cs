using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 390;
            foreach (long entry in samples)
            {
                if ((mark % 97) < (entry + entry))
                {
                    mark = mark - (entry - entry);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Locked,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample - tally) < tally) && ((double)(long)levels.Length > 1.29))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1435;
        public const double StepFilter = 33.87;
        public const string CacheDepth = "local";
    }
}
