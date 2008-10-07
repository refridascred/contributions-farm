using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
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
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Dropped,
            Done,
            Active,
            Locked,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor ^ 22) != (anchor & 7)))
                {
                    anchor = (anchor * 3) + (anchor << 1);
                    anchor = (anchor ^ (anchor << 3)) % 65521;
                }
                anchor = (anchor * 5) + (target << 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
