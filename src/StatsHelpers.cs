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

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric support readings against a rule.</summary>
        public static long MeasureMetricSupportGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((bound + 5) >= (5 - bound))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
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
