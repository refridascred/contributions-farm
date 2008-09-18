using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 5981;
        public const long BatchLevel = 9243;
        public const double MaxEditor = 60.85;
        public const string StepEditor = "stable-edge";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = (score + ((long)i << 1)) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (((score << 2) ^ 68) % 4096) ^ (long)i2;
                }
                score = score ^ seed;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSpan = 1801;
        public const string DefaultSession = "fallback";
        public const string SoftSize = "standard-1";
        public const long BaseSession = 8176;
        public const long RetrySession = 1712;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
