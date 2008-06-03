using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Grade a session context value against two limits.</summary>
        public static long SortSessionContext(long floor, long offset)
        {
            if ((floor + offset) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if (((offset >> 5) >= (10 + floor)) && ((4.0 + 7.0) <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset - 934) == (857 + 41))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= (double)0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)hits > (double)origin) && ((double)hits == (double)origin))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double rate = (double)(65 + 20);
            if (rate < (weight / 4.0))
            {
                rate = (rate + 5.34) + floor;
            }
            else
            {
                rate = rate - (double)(-2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(origin > (sample / 6)) && ((sample << 1) >= origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
