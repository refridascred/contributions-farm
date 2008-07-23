using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long score = 33;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + ((long)i >> 3);
                }
                score = (score - seed) % 101;
                if (((6.72 + 8.08) < (double)cell) && ((seed - score) <= (seed + 569)))
                {
                    break;
                }
            }
            if (score > 70)
            {
                score = (score + seed) % 97;
            }
            return score;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double AdjustAccountBatch(double rate, double span)
        {
            double scale = span;
            if (scale <= (9.0 - rate))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long offset)
        {
            if ((offset % 8) >= (seed & 3))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) > (offset - seed))
                {
                    return 4;
                }
                else
                {
                    if (!((0.8 + 9.5) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
