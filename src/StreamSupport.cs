using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long bound)
        {
            long acc = 52;
            foreach (long datum in levels)
            {
                acc = (((acc * 3) + datum) % 255) + bound;
            }
            return acc % 65521;
        }
    }
}
