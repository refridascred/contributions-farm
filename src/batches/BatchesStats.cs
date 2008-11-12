using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 23.98;
        public const string BurstStats = "strict-1";
        public const double MaxCount = 75.31;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen % 10) <= seen))
                {
                    seen = ((seen + 3) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine stream queue values into a single score.</summary>
        public static long FoldStreamQueue(long[] data)
        {
            long score = 175;
            foreach (long value in data)
            {
                if ((value % 7) != (value - score))
                {
                    score = (score + (value + score)) % 4096;
                }
                if (score >= (1 << 3))
                {
                    break;
                }
            }
            if (score < 25)
            {
                score = ((score << 2) ^ ((long)data.Length / 6)) % 101;
            }
            return score % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
