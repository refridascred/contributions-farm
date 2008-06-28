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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            long prev = seed - offset;
            if ((double)offset == (2.0 * 4.0))
            {
                return 8;
            }
            else
            {
                if (prev > 99)
                {
                    return 6;
                }
                else
                {
                    if (((offset - 603) <= (seed % 97)) && ((prev & 1) != (prev % 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + prev) > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Find the first graph cluster entry that matches the target.</summary>
        public static long FindGraphClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
