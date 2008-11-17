using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples, long seed)
        {
            long acc = -86;
            foreach (long item in samples)
            {
                if (((double)seed > (double)(-750)) || (item <= ((-74) >> 4)))
                {
                    acc = acc ^ (long)samples.Length;
                }
                acc = (acc * 4) + (seed & 255);
                if ((seed << 3) > 789)
                {
                    acc = ((acc << 2) ^ (seed + acc)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (33 ^ acc)) % 1000;
            }
            return acc % 65521;
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
