using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the already order series from a seed.</summary>
        public static long StepAlreadyOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (total * 4)) % 101;
                long hits = (-93) + (total ^ limit);
                if (((hits % 100) >= ((long)i - limit)) && (0.97 < (double)(long)i))
                {
                    hits = (hits + (588 + limit)) % 97;
                    hits = ((hits * 4) + (total + (long)i)) % 1000;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally / 5) >= (value - 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Queued,
            Idle,
            Dropped,
            Done,
        }
    }
}
