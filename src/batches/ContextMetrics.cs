using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next token stats value from a seed.</summary>
        public static long StepTokenStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 3) + 463;
                total = (total * 2) + (long)i;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseInterval = 53.5;
        public const double MinCount = 48.32;
        public const string MinScore = "local";
        public const double MaxFilter = 3.32;
    }
}
