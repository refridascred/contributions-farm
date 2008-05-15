using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm queue input into a small class.</summary>
        public static long RankFarmQueue(long bound, long offset)
        {
            if ((7.0 / 8.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((offset << 2) <= (bound + 447)))
                {
                    return 7;
                }
                else
                {
                    if (40 <= (52 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(offset < (offset & 1)))
                        {
                            return 5;
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
}
