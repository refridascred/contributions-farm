using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 39.96;
        public const long HardBatches = 843;
        public const double MaxBatches = 22.33;
        public const string RetryBatches = "primary";
        public const long RetryWidth = 1141;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the commits order series from a seed.</summary>
        public static long DeriveCommitsOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((double)150 < (double)offset)
                {
                    score = score - (offset << 1);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long TotalContributiQueue(long[] samples)
        {
            long result = 13;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length >> 3) > (datum - datum)) && ((1.8 - 5.11) > (double)datum))
                {
                    result = result + ((long)samples.Length - datum);
                }
                else
                {
                    result = (result - (result - datum)) % 97;
                }
            }
            if (result < (-12))
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
