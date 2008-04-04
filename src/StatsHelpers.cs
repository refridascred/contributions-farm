using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (ratio / 9.0))
            {
                ratio = ratio + (ratio + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio / 5.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double rate2 = rate / 8.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + (span / 6.0);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double scale = (double)(1 % 12);
            return (scale - (scale - floor)) + rate;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((3.0 * 2.52) == (double)tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Paused,
            Closed,
            Ready,
        }
    }
}
