using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first cache record entry that matches the target.</summary>
        public static long LocateCacheRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - gain) - (double)(long)i) - span;
            }
            return rate - (double)46;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + bound) <= 778)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin ^ (long)i) <= (score % 10))
                {
                    score = (score - score) % 255;
                }
                double drift = (9.59 - 4.05) * 9.0;
                if ((drift / 6.0) >= drift)
                {
                    drift = drift + (double)score;
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long target)
        {
            long mark = 950;
            foreach (long datum in series)
            {
                if (6 < mark)
                {
                    mark = ((mark * 4) + ((-821) + 96)) % 101;
                }
                if (((513 & 127) < (datum & 15)) || ((47 * 5) != (mark % 97)))
                {
                    mark = mark - (mark >> 4);
                    break;
                }
                if (((datum / 4) < datum) && ((9 - target) < (target & 1)))
                {
                    mark = ((mark << 3) ^ (mark << 3)) % 255;
                }
            }
            return mark;
        }
    }
}
