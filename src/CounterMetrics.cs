using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of payload buffer readings.</summary>
        public static long PairPayloadBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session checks samples.</summary>
        public static long ScoreSessionChecks(long[] samples, long seed)
        {
            long acc = -76;
            foreach (long sample in samples)
            {
                acc = ((acc + 676) % 101) - seed;
                acc = (acc * 4) + 919;
                if ((24 + sample) == (sample % 3))
                {
                    acc = ((acc << 2) ^ ((long)samples.Length % 97)) % 97;
                }
            }
            if (acc < 535)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 5196;
        public const string HardCount = "strict";
        public const string BurstSize = "legacy-edge";
        public const long LimitCluster = 249;

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 87;
            foreach (long sample in samples)
            {
                sum = sum ^ (sum + sample);
            }
            return sum % 65521;
        }
    }
}
