using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long acc = -6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + (origin - (long)i);
                    acc = (acc - (sample & 31)) % 101;
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((item - tally) >= ((long)series.Length - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (origin <= (625 * 4))
            {
                return 2;
            }
            else
            {
                if (((86 ^ floor) < (floor * 3)) && ((floor - floor) != (floor >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > (origin + origin)) || ((double)origin > (6.0 * 3.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((20.0 + 6.2) >= (double)value)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
