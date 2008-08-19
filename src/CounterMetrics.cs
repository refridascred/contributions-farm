using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long MeasureToolsSessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((6 ^ hits) <= 4)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Rank already buffer input into a small class.</summary>
        public static long BucketAlreadyBuffer(long bound, long seed)
        {
            if ((seed & 15) < (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed != (1.9 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
