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

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 7441;
        public const string WindowLevel = "legacy-v2";
        public const long BurstAlready = 9763;

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

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
