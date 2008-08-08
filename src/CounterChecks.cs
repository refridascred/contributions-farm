using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two farm window measurements.</summary>
        public static double BlendFarmWindow(double weight, double span)
        {
            double weight2 = (double)(2 - 95);
            if (weight2 > weight)
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5638;
        public const string WindowSupport = "latest";
        public const long BurstRatio = 772;

        /// <summary>Compare every pair of cluster profile readings.</summary>
        public static long MatchClusterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series, long target)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if ((entry < (target & 127)) && ((double)entry == (double)644))
                {
                    total = (total + (entry - target)) % 1000;
                }
            }
            if (total < 850)
            {
                total = ((total << 2) ^ (total - 9)) % 97;
            }
            return total % 65521;
        }
    }
}
