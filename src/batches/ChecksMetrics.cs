using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (1.3 <= (double)datum)
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a command channel figure with a bias.</summary>
        public static double BlendCommandChannel(double gain, double floor)
        {
            double ratio = gain;
            if (ratio > (floor + ratio))
            {
                ratio = ratio + (double)(-2);
            }
            else
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (floor + ratio)) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 19.0) + (double)(long)i) + span;
            }
            return bias - 19.0;
        }
    }
}
