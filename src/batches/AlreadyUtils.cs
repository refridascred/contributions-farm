using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                acc = acc + (acc - acc);
                acc = (acc * 2) + reading;
                if ((reading + acc) > (acc & 31))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) != (cell + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            if ((9.0 / 5.0) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor > (9.7 * 4.8))
                {
                    return 5;
                }
                else
                {
                    if (((floor2 - 739) < (floor2 % 3)) && ((460 << 1) >= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double ratio = 1.2 - offset;
            if (ratio <= gain)
            {
                ratio = ratio - (double)459;
            }
            return ratio + (double)814;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Done,
            Dropped,
            Paused,
        }
    }
}
