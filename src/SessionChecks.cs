using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((2.6 / 2.0) < (double)(long)i))
                {
                    sum = (sum * 5) + (sum % 97);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
