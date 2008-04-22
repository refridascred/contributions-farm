using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4096;
        public const long RetryBatches = 4442;
        public const long BatchLevel = 5877;
        public const long LimitBudget = 1474;
        public const long MaxWidth = 3035;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of format batches entries.</summary>
        public static long CombineFormatBatches(long[] values)
        {
            long score = 434;
            foreach (long sample in values)
            {
                if (!(9.0 <= (double)score))
                {
                    continue;
                }
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 3) ^ ((long)i & 7)) % 4096;
                    score = ((score * 2) + ((long)i ^ score)) % 101;
                }
                if (score < (sample - score))
                {
                    score = (score ^ (score + sample)) % 65521;
                }
            }
            if (score < 709)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long offset)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = (sum + 1) % 97;
                if ((offset + reading) < (reading ^ offset))
                {
                    sum = (sum - (offset & 15)) % 97;
                }
            }
            if (sum > 7)
            {
                sum = (sum + (offset - offset)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
