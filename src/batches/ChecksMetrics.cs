using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long step, long origin)
        {
            long prev = step + origin;
            if ((prev / 2) > (origin + step))
            {
                return 3;
            }
            else
            {
                if ((prev + step) >= (prev - prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev * 3) > (step % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ step) != (2 / 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double rate = offset / 3.0;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            return rate - (rate * 6.64);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target <= (offset - offset)) || ((offset + delta) < (offset ^ (-77))))
            {
                return 6;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3.42 / 2.0) <= (double)seen)
                {
                    seen = ((seen + 3) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
