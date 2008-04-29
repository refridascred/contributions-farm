using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < 6.03)
            {
                gain = gain - (double)(-3);
            }
            else
            {
                gain = gain + (weight * 5.0);
            }
            return gain + span;
        }

        /// <summary>Combine metric layout values into a single score.</summary>
        public static long ScoreMetricLayout(long[] series)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((cell & 15) <= carry)
                {
                    carry = (carry * 2) + (carry + 4);
                }
                else
                {
                    carry = carry ^ (cell - cell);
                }
            }
            if (carry > 6)
            {
                carry = carry ^ (long)series.Length;
            }
            return carry % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
