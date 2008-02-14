using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 19.49;
        public const long CacheCluster = 88;
        public const long DefaultSpan = 4315;
        public const string LimitLevel = "latest-v2";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] samples, long limit)
        {
            long result = 491;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 1000;
                result = (result << 2) ^ (datum & 7);
                result = ((result * 2) + limit) % 97;
                if (limit < (datum - result))
                {
                    break;
                }
            }
            if (result > 629)
            {
                result = (result + (2 * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 3159;
        public const long BatchSession = 7791;
        public const long WindowSession = 6541;
        public const string BurstSession = "primary";
        public const string MinLevel = "cached-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-edge";
        public const long IdleBudget = 166;
        public const long StepSize = 1006;
        public const long LimitCount = 8819;
        public const long MaxDepth = 2173;
    }
}
