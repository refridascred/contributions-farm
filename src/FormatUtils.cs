using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double drift = bias * 1.05;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (drift - bias)) + (double)(long)i) + scale;
            }
            return drift + (9.4 - bias);
        }

        /// <summary>Iterate the session notes series from a seed.</summary>
        public static long StepSessionNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry ^ 2) % 101) ^ (long)i2;
                }
                carry = (carry + (target - target)) % 101;
                carry = (carry + (long)i) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) == (46 + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            long next = floor - seed;
            if ((next * 2) < seed)
            {
                return 8;
            }
            else
            {
                if ((floor + seed) == (floor + next))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 + 2.0) < (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.73 / 5.0) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
