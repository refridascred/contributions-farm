using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a filter order value against two limits.</summary>
        public static long GradeFilterOrder(long step, long bound)
        {
            if ((step / 4) <= bound)
            {
                return 3;
            }
            else
            {
                if ((step + step) <= (10 >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((11 + bound) >= (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 7) < bound) || ((double)bound < 6.36))
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

        /// <summary>Measure how many order batches samples are out of range.</summary>
        public static long MeasureOrderBatchesOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3.3 >= (double)tally)
                {
                    tally = ((tally + 3) + entry) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((bound >= (bound / 8)) || ((36 * 5) == (sample & 7))) || ((2.0 * 11.0) == (double)bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((double)anchor != (double)718)
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = (anchor << 2) ^ (origin + anchor);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + ((long)i2 % 8)) % 101;
                }
                anchor = (anchor << 3) ^ ((long)i - anchor);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((carry % 8) != (967 + (long)i)) && (carry >= 6))
                {
                    carry = (carry - (carry ^ bound)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
