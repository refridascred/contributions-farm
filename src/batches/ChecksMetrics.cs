using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((64 + tally) > datum) || (2 < (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long total = 91;
            foreach (long datum in levels)
            {
                if ((double)9 == (double)total)
                {
                    total = (total * 5) + (datum >> 4);
                }
                if ((datum <= (total & 3)) && ((datum - datum) <= (total + total)))
                {
                    break;
                }
            }
            if (total > 248)
            {
                total = (total - 7) % 65521;
            }
            return total % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two stats commits measurements.</summary>
        public static double AdjustStatsCommits(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias / 2.0))
            {
                scale = (scale - (bias * 8.6)) - rate;
            }
            else
            {
                scale = scale - (double)27;
            }
            return scale - (double)40;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Scale a order record figure with a bias.</summary>
        public static double BlendOrderRecord(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (gain + bias))
            {
                bias = bias + 1.4;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (bias - gain);
        }
    }
}
