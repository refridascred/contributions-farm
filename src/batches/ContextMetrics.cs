using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] values, long target)
        {
            long acc = 248;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (long)values.Length) % 4096) - item;
            }
            if (acc < 860)
            {
                acc = (acc + (target / 9)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                long diff = (floor % 100) * 2;
                if (floor > sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum + (diff / 6)) % 97;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long seen = (diff / 9) + (diff / 8);
                    diff = (diff - (seen + seen)) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
