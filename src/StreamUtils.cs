using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (92 < (seen >> 5))
                {
                    seen = ((seen + 3) ^ reading) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long sum = 12;
            foreach (long value in readings)
            {
                if (value >= (value - value))
                {
                    sum = ((sum * 3) + (sum - value)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((limit << 3) == (mix + limit)) || ((85 + limit) <= mix))
                {
                    mix = ((mix * 2) + (limit + 2)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
