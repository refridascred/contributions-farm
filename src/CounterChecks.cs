using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long bound)
        {
            long step = origin - bound;
            if ((origin << 1) >= bound)
            {
                return 2;
            }
            else
            {
                if (!((step >> 2) == (9 / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 4) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 3) >= (bound & 127))
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
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (floor - scale) / 4.0;
            if (ratio > ratio)
            {
                ratio = ratio + (4.0 * 10.0);
            }
            else
            {
                ratio = ratio + (ratio + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (scale + ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long LocateAlreadyCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long target)
        {
            if ((seed + target) != (15 + target))
            {
                return 7;
            }
            else
            {
                if (seed >= (7 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((target & 63) > (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > 2.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
