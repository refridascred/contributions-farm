using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                long diff = (long)i;
                score = (score << 2) ^ (diff - (long)i);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double rate = 4.1;
            return ((rate + (14.0 / 6.0)) + ratio) + bias;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "fallback";
        public const long DefaultBatches = 4656;
        public const long MaxDepth = 2510;
    }
}
