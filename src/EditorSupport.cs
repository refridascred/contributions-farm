using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the entry batch entries that pass the check.</summary>
        public static long MeasureEntryBatchOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.0 + 0.54) > (double)limit)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double ratio = (double)(1 * 3);
            return ((ratio - (double)96) + gain) + bias;
        }

        /// <summary>Look up the position of a farm filter sample.</summary>
        public static long LookupFarmFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) > 2)
            {
                return 0;
            }
            else
            {
                if (!(origin <= (bound * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (1.32 + 6.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (7.3 + 9.6)) || (origin < (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Paused,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of commits cache readings.</summary>
        public static long OverlapCommitsCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
