using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long offset, long seed)
        {
            if ((offset - offset) <= (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (0.64 * 9.86))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) >= (seed ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset + seed) <= (offset << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                if (anchor >= (item - item))
                {
                    anchor = (anchor ^ (item % 16)) % 255;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (item <= (anchor % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up report batch samples.</summary>
        public static long MatchReportBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
