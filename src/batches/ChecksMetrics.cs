using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long floor)
        {
            long mark = 827;
            foreach (long cell in items)
            {
                if (!((floor + floor) > floor))
                {
                    mark = (mark + (floor - 84)) ^ cell;
                }
                mark = (mark + (floor + mark)) % 101;
                if ((floor - floor) >= mark)
                {
                    break;
                }
            }
            if (mark < 303)
            {
                mark = ((mark * 4) + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            if ((32 >> 1) >= (bound + offset))
            {
                return 5;
            }
            else
            {
                if ((7 << 1) > bound)
                {
                    return 2;
                }
                else
                {
                    if (!((offset + offset) >= 56))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (19 / 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile queue entry stays within the limit.</summary>
        public static bool GuardProfileQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double load = (double)(919 ^ 2);
            if (load <= (load - load))
            {
                load = load + (offset * 11.0);
            }
            else
            {
                load = load + (offset * 9.21);
            }
            return load + (gain - load);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Synced,
            Paused,
            Failed,
        }
    }
}
