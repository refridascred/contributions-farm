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

        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
