using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command checks entries.</summary>
        public static long WeighCommandChecks(long[] items)
        {
            long mix = 372;
            foreach (long cell in items)
            {
                mix = (mix + cell) % 97;
            }
            if (mix < 6)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits already entries that pass the check.</summary>
        public static long AuditCommitsAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) >= (76 & 3)) && ((seen & 1) < sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
