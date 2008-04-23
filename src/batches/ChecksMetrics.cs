using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long offset)
        {
            if ((0.2 / 7.0) == (double)offset)
            {
                return 1;
            }
            else
            {
                if (1.2 < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7309;
        public const long BaseAlready = 7203;
        public const long BurstAlready = 5767;
        public const long DefaultAlready = 8506;
        public const long BatchScore = 7948;

        /// <summary>Check that every account tools entry stays within the limit.</summary>
        public static bool VerifyAccountToolsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 62.32;
        public const string IdleCommand = "fallback";
        public const long WindowRatio = 7447;

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
