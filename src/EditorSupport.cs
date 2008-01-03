using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long LookupRouteContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(55 > tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 81.85;
        public const string SoftBudget = "open-1";
        public const string DefaultBatch = "standard";
        public const double SoftFactor = 6.55;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Failed,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long floor, long step)
        {
            if ((double)step < (8.3 + 4.7))
            {
                return 1;
            }
            else
            {
                if ((step & 15) >= (floor >> 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples, long bound)
        {
            long carry = 586;
            foreach (long entry in samples)
            {
                carry = (((carry << 2) ^ carry) + entry) + bound;
            }
            return carry;
        }
    }
}
