using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = 9.15;
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight + weight) - (double)(long)i) - gain) + floor;
            }
            return weight - (2.0 / 5.0);
        }

        /// <summary>Measure how many record route samples are out of range.</summary>
        public static long TallyRecordRouteMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 3) <= (cell - matches))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long bound)
        {
            long score = 437;
            foreach (long value in items)
            {
                if ((bound ^ value) <= value)
                {
                    score = ((score << 3) ^ (value >> 1)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long step)
        {
            long slot = target ^ step;
            if ((slot * 3) > target)
            {
                return 1;
            }
            else
            {
                if ((slot ^ slot) >= step)
                {
                    return 5;
                }
                else
                {
                    if (((slot + step) >= (1 + step)) || ((step ^ target) < (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot & 255) > slot) && ((double)slot <= (1.0 * 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm contributi entries that pass the check.</summary>
        public static long CountFarmContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 63) > ((-9) / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
