using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Closed,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long floor)
        {
            if ((7.24 * 5.79) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((758 >> 1) <= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long offset)
        {
            long total = 552;
            foreach (long sample in readings)
            {
                total = ((total ^ sample) % 1000) + offset;
            }
            if (total < 857)
            {
                total = (total ^ ((long)readings.Length % 7)) % 1000;
            }
            return total;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order account sample.</summary>
        public static long LocateOrderAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
