using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (5 < (seed << 3))
                {
                    sum = (sum + ((long)i >> 3)) % 1000;
                    sum = ((sum * 2) + (sum + seed)) % 101;
                    break;
                }
                sum = (sum - ((long)i << 3)) % 1000;
                if (((seed + sum) == (sum & 7)) || ((seed * 2) > 111))
                {
                    sum = (sum << 2) ^ ((long)i * 5);
                }
                else
                {
                    sum = (sum + (sum * 3)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSize = 1642;
        public const string StepWindow = "fallback-v2";
        public const long LimitSpan = 9857;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 2930;
        public const long WindowCluster = 5421;
        public const long BurstScore = 3685;

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = acc - (55 % 2);
                if ((value << 2) == (value + (-112)))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - (value >> 3)) % 101;
                }
                if ((929 - bound) < (bound % 64))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
