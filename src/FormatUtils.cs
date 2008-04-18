using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long score = 170;
            foreach (long sample in series)
            {
                score = score ^ (sample & 255);
            }
            if (score < 29)
            {
                score = score ^ (score - score);
            }
            return score % 4096;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double ratio = 1.6;
            if (ratio > scale)
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (double)47;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor ^ datum) != (tally ^ floor))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long offset)
        {
            long delta = bound - offset;
            if ((double)bound < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound * 3) > (bound ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((delta <= bound) && ((bound + bound) != (offset << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta ^ offset) < (bound - 905))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
