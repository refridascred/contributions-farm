using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1 ^ 26) > (hits % 60))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardLevel = 34.77;
        public const string HardBatches = "legacy-1";
        public const double DefaultBatches = 46.54;
        public const long IdleBatches = 8784;
        public const long LimitBatches = 1480;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long step, long seed)
        {
            long gap = step ^ seed;
            if (gap >= (gap & 1))
            {
                return 1;
            }
            else
            {
                if ((12.0 / 9.0) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((0.29 - 11.0) <= (double)gap)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.7 * 5.03) < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
