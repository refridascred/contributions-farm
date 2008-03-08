using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long AuditProfileGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - tally) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long CountFilterAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count ^ count) > count) || (count > (cell / 8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double weight = 8.88;
            return (weight + floor) + ratio;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + floor) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (!((double)511 != (double)seed))
            {
                return 3;
            }
            else
            {
                if ((4.33 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) >= (target * 2)) || ((double)seed == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
