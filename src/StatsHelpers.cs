using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Rank account batch input into a small class.</summary>
        public static long BucketAccountBatch(long target, long offset)
        {
            long offset2 = target - offset;
            if ((2 * 5) > (offset2 + (-4)))
            {
                return 0;
            }
            else
            {
                if ((18 % 3) == (offset2 << 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset < 14.0) || ((offset - offset2) <= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
