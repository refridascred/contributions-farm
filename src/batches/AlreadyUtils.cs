using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Idle,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool GuardContributiPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long IterateBufferCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix ^ (limit - limit)) % 97;
                if ((long)i > limit)
                {
                    mix = ((mix * 5) + limit) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 202;
            foreach (long reading in data)
            {
                if (!((double)sum >= (6.0 * 2.3)))
                {
                    sum = (sum ^ (sum + reading)) % 255;
                }
                else
                {
                    sum = sum ^ sum;
                }
                if ((sum + sum) != (35 + reading))
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
                if (((long)data.Length & 63) == (sum + reading))
                {
                    sum = (sum - sum) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 4096;
                }
            }
            if (sum > 86)
            {
                sum = (sum ^ (sum + 92)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9445;
        public const long WindowScore = 271;
        public const long MinInterval = 8531;
        public const long BatchDepth = 1899;
        public const string StepTools = "latest-1";
    }
}
