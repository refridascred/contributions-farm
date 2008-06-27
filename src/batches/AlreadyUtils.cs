using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 59;
            foreach (long sample in readings)
            {
                score = ((score * 5) + (sample << 3)) % 1000;
            }
            if (score < 79)
            {
                score = (score << 3) ^ (score - 49);
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxBudget = 19.73;
        public const long MinPayload = 6814;
        public const string StepPayload = "alpha-1";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long limit)
        {
            if ((limit / 5) == (offset >> 3))
            {
                return 3;
            }
            else
            {
                if (!(offset > (limit + 93)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) <= (limit + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double rate = (double)616 * 7.9;
            return ((rate + (double)592) + gain) + floor;
        }
    }
}
