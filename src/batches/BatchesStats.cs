using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values, long bound)
        {
            long mix = 6;
            foreach (long value in values)
            {
                if (((double)bound != (9.6 - 3.0)) || (bound <= ((-41) - (long)values.Length)))
                {
                    continue;
                }
                if ((value % 7) <= value)
                {
                    mix = mix ^ (mix - mix);
                }
            }
            if (mix < 7)
            {
                mix = mix ^ (bound + bound);
            }
            return mix;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((0 & 63) <= (anchor + anchor)) && ((bound & 7) > (long)i))
                {
                    anchor = (anchor ^ ((long)i + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + bound;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long TallyOrderPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < (hits % 100))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
