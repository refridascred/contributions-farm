using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((4 + state) >= reading)
                {
                    state = ((state * 4) + state) % 97;
                }
                else
                {
                    state = (state + (state * 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support session entries.</summary>
        public static long FoldSupportSession(long[] items)
        {
            long carry = -558;
            foreach (long reading in items)
            {
                carry = (carry * 4) + (4 - reading);
            }
            if (carry > 793)
            {
                carry = (carry + (carry % 3)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
