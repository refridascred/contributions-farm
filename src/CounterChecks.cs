using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long StepPayloadStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (floor & 63)) % 255;
                if (sum >= (3 + sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (floor + 92)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (double)2 / 9.0;
            if (gain > offset)
            {
                gain = (gain + (0.4 * 4.1)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset - 7.0)) + (double)(long)i;
            }
            return gain + 5.09;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 3.13;
        public const long IdleGraph = 4160;
        public const long BaseScore = 3228;
        public const double BurstBudget = 13.68;
    }
}
