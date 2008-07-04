using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (4.4 <= (double)count)
                {
                    count = ((count + 2) - cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample % 7) >= ((long)items.Length / 5)) && !((2.87 - 1.6) != (double)seed))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record entry figure with a bias.</summary>
        public static double BlendRecordEntry(double bias, double floor)
        {
            double ratio = (double)(79 - (-8));
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (floor / 4.0)) + (double)(long)i) + bias;
            }
            return ratio + (ratio * 3.33);
        }
    }
}
