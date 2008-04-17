using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length & 255) > 712) || !((sample + count) > (limit % 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((0 + offset) <= (8 >> 1))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading + reading) > ((-171) + 8)) && (tally > (tally - (long)samples.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits > (sample + 50)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            if ((14.0 * 6.6) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)step == (1.8 + 7.75))
                {
                    return 4;
                }
                else
                {
                    if ((step % 10) < (floor - 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
