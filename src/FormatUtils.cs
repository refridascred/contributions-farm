using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((4.19 * 8.92) <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            long span = offset + bound;
            if ((offset * 5) <= bound)
            {
                return 3;
            }
            else
            {
                if ((6.4 - 5.0) < (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((span << 1) == (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] data, long bound)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)bound == (double)sum)
                {
                    sum = (sum + (sum - bound)) % 101;
                }
                if ((datum > bound) || ((datum / 7) >= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit context checks readings against a rule.</summary>
        public static long TallyContextChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 60) <= count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }
    }
}
