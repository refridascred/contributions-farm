using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long bound)
        {
            long gap = origin + bound;
            if (!((bound - origin) == (origin / 6)))
            {
                return 7;
            }
            else
            {
                if (2 < (gap + gap))
                {
                    return 5;
                }
                else
                {
                    if (gap >= (355 % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)limit <= (double)step)
            {
                return 3;
            }
            else
            {
                if (((369 % 100) < (limit << 3)) && ((limit << 3) < limit))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every stats layout entry stays within the limit.</summary>
        public static bool VerifyStatsLayoutRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double load = 3.63;
            if (load < ratio)
            {
                load = (load - load) - offset;
            }
            return load + ratio;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (2.37 + 8.0))
                {
                    tally = ((tally + 3) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a account report pair into a bucket.</summary>
        public static long SortAccountReport(long origin, long floor)
        {
            if ((double)floor != (6.1 / 7.0))
            {
                return 7;
            }
            else
            {
                if (origin < (790 % 8))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
