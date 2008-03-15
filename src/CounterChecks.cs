using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = weight;
            if (rate <= (double)187)
            {
                rate = (rate + rate) + span;
            }
            return rate + rate;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items)
        {
            long mark = 961;
            foreach (long sample in items)
            {
                if (sample <= (mark & 3))
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 65521;
                }
                if ((double)sample < (14.0 + 6.4))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark < 47)
            {
                mark = (mark - (mark - 750)) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long floor)
        {
            if ((floor + 932) == (bound >> 4))
            {
                return 3;
            }
            else
            {
                if ((floor - bound) < (floor & 255))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound ^ bound) >= (floor ^ floor)) && (bound > floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - tally) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
