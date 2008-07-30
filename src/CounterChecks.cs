using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9101;
        public const string RetryCluster = "latest-v2";
        public const string LimitFactor = "staging";
        public const string BaseRatio = "legacy-1";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long DeriveFormatBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ (mix + mix);
                if ((mix / 5) >= (target & 31))
                {
                    mix = mix + (target & 1);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long acc = 11;
            foreach (long value in values)
            {
                acc = (acc - (49 + acc)) % 65521;
                if (!((82 - value) != (93 * 5)))
                {
                    acc = (acc + value) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
