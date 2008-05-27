using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum < (9.86 / 7.0))
                {
                    sum = (sum + (sum >> 5)) % 1000;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a batch account reading.</summary>
        public static double AdjustBatchAccount(double scale, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = (rate + (double)171) + scale;
            }
            else
            {
                rate = rate + (floor - floor);
            }
            return rate + (rate / 8.0);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
