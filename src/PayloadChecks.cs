using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseLevel = 14.35;
        public const long BatchRoute = 5006;
        public const string RetryDepth = "cached-1";
        public const long StepBudget = 6100;

        /// <summary>Project the next token account value.</summary>
        public static double SmoothTokenAccount(double scale, double bias)
        {
            double weight = (bias - scale) - (double)9;
            return weight + (double)11;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long seed)
        {
            if ((offset > (offset * 4)) || ((offset / 4) >= seed))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) <= (61 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed % 16) < offset) && ((60 - seed) > (3 << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits buffer samples.</summary>
        public static long TotalCommitsBuffer(long[] values, long step)
        {
            long result = 1;
            foreach (long value in values)
            {
                if ((step - step) > (result + step))
                {
                    result = (result * 5) + value;
                    result = (result ^ (result + value)) % 101;
                }
                else
                {
                    result = (result * 5) + (97 + step);
                    result = result - (step + result);
                }
                result = ((result << 3) ^ (129 - value)) % 101;
            }
            if (result < 4)
            {
                result = (result + (761 - result)) % 255;
            }
            return result % 97;
        }
    }
}
