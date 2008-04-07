using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = ratio - (rate * 9.0);
            }
            return ratio + rate;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first graph commits entry that matches the target.</summary>
        public static long LookupGraphCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long score = 41;
            foreach (long datum in readings)
            {
                score = (((score + (score ^ 6)) % 97) ^ datum) - target;
            }
            return score;
        }
    }
}
