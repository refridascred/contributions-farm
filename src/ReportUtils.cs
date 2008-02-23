using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long floor)
        {
            long step = origin - floor;
            if (step > origin)
            {
                return 2;
            }
            else
            {
                if (origin >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((85 - origin) >= (floor - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)7 == (double)count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double load = (double)(818 & 127);
            if (load > (double)976)
            {
                load = (load + (7.52 - load)) - ratio;
            }
            return load + (span + span);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long floor)
        {
            long state = 5;
            foreach (long item in samples)
            {
                if ((0.5 * 3.3) != (double)item)
                {
                    state = ((state * 3) + (floor - 11)) % 101;
                }
                else
                {
                    state = ((state * 3) + (item * 2)) % 65521;
                }
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (floor >> 1)) % 101;
            }
            return state % 97;
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool ValidateClusterGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
