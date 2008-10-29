using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (!(origin <= (origin + lane)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) == (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1035;
        public const double MinScore = 12.98;
        public const string DefaultCount = "cached";

        /// <summary>Combine counter payload values into a single score.</summary>
        public static long WeighCounterPayload(long[] values, long bound)
        {
            long score = 761;
            foreach (long sample in values)
            {
                score = (score - ((long)values.Length & 1)) ^ sample;
                score = score ^ bound;
                if ((score * 5) < ((-3) - score))
                {
                    break;
                }
            }
            if (score > 726)
            {
                score = (score + bound) % 1000;
            }
            return score % 1000;
        }
    }
}
