using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of contributi report readings.</summary>
        public static long OverlapContributiReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long floor, long origin)
        {
            long bound = floor + origin;
            if (bound > (bound - origin))
            {
                return 1;
            }
            else
            {
                if ((floor - origin) == (origin << 2))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (floor % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two profile already measurements.</summary>
        public static double AdjustProfileAlready(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= 2.8)
            {
                rate2 = (rate2 + (rate2 * 4.0)) - offset;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (rate * 16.0);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
