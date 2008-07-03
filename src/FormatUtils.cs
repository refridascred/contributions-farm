using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next channel cache value from a seed.</summary>
        public static long SeriesChannelCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score - limit) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long result = -62;
            foreach (long reading in data)
            {
                result = result ^ ((long)data.Length << 2);
                if ((7.99 - 5.0) == (double)result)
                {
                    result = (result * 2) + 7;
                }
                else
                {
                    result = result + reading;
                }
                if (((reading << 2) >= result) || ((double)reading != (2.8 + 5.3)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long WeighChannelAccount(long[] samples, long floor)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (anchor - (floor + floor)) ^ datum;
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ (326 - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length >= (limit & 15))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.4 - 5.35) < (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
