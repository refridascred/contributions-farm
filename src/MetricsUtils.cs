using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long TallyCounterNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) <= ((long)series.Length >> 1))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples)
        {
            long score = -943;
            foreach (long cell in samples)
            {
                score = ((score ^ (score / 9)) % 101) ^ cell;
            }
            if (score > 7)
            {
                score = score + (long)samples.Length;
            }
            return score;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long MeasureSupportStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((52 - 14) < (reading - 9)) || ((reading ^ seen) == (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
