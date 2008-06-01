using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ item;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long limit)
        {
            if (((limit % 12) == (floor >> 5)) || ((double)floor >= (5.2 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) <= (floor + 680))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long bound)
        {
            long prev = floor - bound;
            if (((3.0 / 3.0) <= (double)floor) || ((floor >> 1) <= (floor & 127)))
            {
                return 8;
            }
            else
            {
                if (6.67 >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)prev <= (9.1 + 6.98))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((301 * 4) != (bound << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
