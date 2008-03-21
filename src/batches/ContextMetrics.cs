using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter batches values into a single score.</summary>
        public static long CombineCounterBatches(long[] levels, long offset)
        {
            long anchor = 869;
            foreach (long item in levels)
            {
                anchor = anchor - (offset - anchor);
                if (item < (item - offset))
                {
                    anchor = (anchor + (item + 0)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate contributi metrics readings against a bound.</summary>
        public static bool ValidateContributiMetricsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((matches % 100) > 598) && (((-86) >= matches) || (cell <= (cell >> 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
