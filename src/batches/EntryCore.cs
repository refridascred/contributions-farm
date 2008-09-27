using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order batch entry that matches the target.</summary>
        public static long FindOrderBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long limit)
        {
            if ((step & 127) < (949 - limit))
            {
                return 8;
            }
            else
            {
                if ((5.8 >= (double)limit) || ((step >> 4) <= 433))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 4) <= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
