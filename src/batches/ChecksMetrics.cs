using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((7.8 < (double)value) && ((double)value == (3.84 + 11.0))))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitRatio = 1663;
        public const string BaseSpan = "staging-v2";
        public const string MaxBatch = "open-edge";

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
