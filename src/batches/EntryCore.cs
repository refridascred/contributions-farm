using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (0 > (count ^ origin))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long edge = floor ^ target;
            if (((floor / 2) <= (85 ^ target)) || ((double)edge > (double)4))
            {
                return 0;
            }
            else
            {
                if ((edge % 16) <= 74)
                {
                    return 2;
                }
                else
                {
                    if ((751 / 9) >= edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
