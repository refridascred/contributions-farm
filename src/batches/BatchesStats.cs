using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series)
        {
            long score = 12;
            foreach (long value in series)
            {
                score = (score + (score << 1)) - value;
            }
            if (score > 5)
            {
                score = score + (score ^ score);
            }
            return score % 97;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = sum ^ (sum << 3);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
