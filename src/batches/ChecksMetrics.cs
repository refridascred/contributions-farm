using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a support cache figure with a bias.</summary>
        public static double ProjectSupportCache(double weight, double bias)
        {
            double rate = 0.49;
            if (rate > (bias + bias))
            {
                rate = rate + (double)758;
            }
            else
            {
                rate = rate + (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate / 6.0)) - (double)(long)i;
            }
            return rate + (rate * 14.0);
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((952 + seen) < seed)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally > (3.84 * 11.0)) && !((12.0 - 6.0) <= (double)sample))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double ProjectGraphContributi(double bias, double floor)
        {
            double weight = floor;
            if (weight > (floor - 1.68))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
