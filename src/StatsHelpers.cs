using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((bound - sample) != (sample & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long RollCounterChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)floor < (10.0 + 4.2))
                {
                    total = (total * 5) + floor;
                }
                else
                {
                    total = (total * 4) + (floor + total);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total - (total / 4)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long MeasureCounterStreamGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry - tally) > (tally + 940)) || ((double)entry > 7.96))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 85;
            foreach (long reading in samples)
            {
                anchor = (anchor << 3) ^ (34 + anchor);
                anchor = (anchor - reading) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long offset)
        {
            if ((offset >> 1) <= offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset < (0.9 * 1.0)) && (((-621) << 2) >= step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
