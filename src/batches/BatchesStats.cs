using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long score = 6;
            foreach (long datum in readings)
            {
                if (9.76 <= (double)datum)
                {
                    score = ((score << 2) ^ (target + datum)) % 97;
                }
                else
                {
                    score = score ^ (score >> 4);
                }
            }
            if (score < (-26))
            {
                score = (score - (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
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
