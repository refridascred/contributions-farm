using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheSize = 94.47;
        public const long CacheWidth = 8096;
        public const long IdleInterval = 5677;
        public const string StepBuffer = "strict-edge";

        /// <summary>Derive the next token channel value from a seed.</summary>
        public static long IterateTokenChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (64 % 3)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)9)
            {
                rate = (rate - rate) + gain;
            }
            else
            {
                rate = rate + 4.1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-31)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 586;
        public const long CacheCount = 3430;
        public const double IdleLevel = 98.67;
        public const long BatchQueue = 7662;

        /// <summary>Roll a session cluster counter forward.</summary>
        public static long RollSessionCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + 399) <= offset)
                {
                    sum = (sum << 2) ^ ((long)i & 7);
                    sum = ((sum * 4) + (6 / 9)) % 101;
                }
                else
                {
                    sum = (sum ^ ((long)i % 64)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
