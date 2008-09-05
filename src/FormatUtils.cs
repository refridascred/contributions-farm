using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Queued,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long CountAlreadyTokenGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits - hits) != (item >> 3)) || ((6.43 + 0.1) < (double)seed))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((859 <= (long)i) || ((acc / 3) >= (limit >> 3)))
                {
                    acc = (acc << 3) ^ ((long)i & 7);
                }
                acc = (acc << 3) ^ acc;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = acc ^ ((long)i2 * 2);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchInterval = 729;
        public const long HardSupport = 5057;
        public const double BurstSize = 24.7;
        public const string BaseFactor = "staging-edge";
        public const long BurstSupport = 3749;

        /// <summary>Find the first profile tools entry that matches the target.</summary>
        public static long LookupProfileToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account context sample.</summary>
        public static long SeekAccountContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
