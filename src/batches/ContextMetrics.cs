using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                if (((cell & 7) == (cell + mix)) && ((1.03 + 7.8) <= (double)mix))
                {
                    mix = (mix * 2) + (57 / 9);
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (mix * 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long offset)
        {
            if (((double)offset >= (double)66) || ((5.41 / 8.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (9.88 - 5.6))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (((-740) < (prev / 6)) || (bound < (floor + bound)))
            {
                return 2;
            }
            else
            {
                if ((6.5 + 5.97) != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((prev + floor) < prev) || (prev >= (0 + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev % 5) < (prev << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length > (double)38)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
