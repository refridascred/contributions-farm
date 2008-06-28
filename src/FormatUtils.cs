using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a format contributi reading.</summary>
        public static double SmoothFormatContributi(double weight, double floor)
        {
            double gain = weight;
            if (gain < (floor / 6.0))
            {
                gain = gain - (weight / 3.0);
            }
            return gain - floor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (3 >= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 3) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading - reading) == (61 / 4)) && ((tally >> 2) < (reading + tally))) && (reading > (reading ^ reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long AuditBatchSchemaOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((2.0 / 6.0) > (double)count) && ((step % 5) > count))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
