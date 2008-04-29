using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long ClassifyGraphCommits(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (!((double)offset > 1.0))
            {
                return 8;
            }
            else
            {
                if ((prev & 3) > prev)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) >= (57 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((9.5 / 5.0) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record buffer figure with a bias.</summary>
        public static double AdjustRecordBuffer(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (ratio * 12.0))
            {
                gain = gain + (6.3 - 7.09);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (9.0 + 7.35)) - (double)(long)i;
            }
            return gain - (double)689;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
