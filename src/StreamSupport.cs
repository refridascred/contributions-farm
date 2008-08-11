using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Active,
            Failed,
            Idle,
            New,
        }

        /// <summary>Derive the next entry metric value from a seed.</summary>
        public static long RollEntryMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long seed)
        {
            long result = 84;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (148 + sample)) % 4096) + (long)i2;
                }
                if ((seed + result) > (-779))
                {
                    result = result - (seed + 16);
                }
            }
            if (result < 122)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
