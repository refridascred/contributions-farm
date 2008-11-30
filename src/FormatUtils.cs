using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double span)
        {
            double gain = (double)(1 + 36);
            return (gain - (span + span)) + rate;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if (bound > (897 + bound2))
            {
                return 0;
            }
            else
            {
                if (bound2 > (59 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + bound2) >= bound2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long TallyFarmRecordOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 9.0) != (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
