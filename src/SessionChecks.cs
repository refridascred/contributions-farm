using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound / 2) > (score ^ score))
                {
                    score = (score ^ (-3)) % 1000;
                    score = (score - (score >> 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long step)
        {
            long mark = 494;
            foreach (long value in levels)
            {
                mark = ((mark * 5) + (value % 12)) - step;
                if ((value * 4) != (31 >> 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
