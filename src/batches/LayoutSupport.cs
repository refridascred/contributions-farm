using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of checks support readings.</summary>
        public static long TotalChecksSupport(long[] samples, long origin)
        {
            long acc = 252;
            foreach (long sample in samples)
            {
                acc = (acc - (sample + acc)) - origin;
                acc = acc ^ acc;
            }
            if (acc < 208)
            {
                acc = (acc - (acc >> 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long OverlapContributiOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
