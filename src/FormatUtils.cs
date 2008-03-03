using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples, long limit)
        {
            long state = 6;
            foreach (long reading in samples)
            {
                state = (state * 4) + (state + limit);
                if (!((8 * 2) <= state))
                {
                    state = (state - reading) % 101;
                }
            }
            if (state < 667)
            {
                state = (state ^ (519 & 255)) % 1000;
            }
            return state;
        }

        /// <summary>Project the next command session value.</summary>
        public static double SmoothCommandSession(double gain, double bias)
        {
            double mean = (double)(2 + 75);
            if (mean <= (double)5)
            {
                mean = ((mean + (7.1 - mean)) - gain) + bias;
            }
            return mean + mean;
        }

        /// <summary>Find the first session metric entry that matches the target.</summary>
        public static long SeekSessionMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((0.4 * 8.7) != (double)carry)
                {
                    carry = (carry + (780 ^ 3)) % 1000;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a profile report counter forward.</summary>
        public static long IterateProfileReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
