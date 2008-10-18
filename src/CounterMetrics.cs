using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Synced,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of session batches readings.</summary>
        public static long OverlapSessionBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long bound)
        {
            long acc = 582;
            foreach (long reading in series)
            {
                if ((acc >> 3) < bound)
                {
                    acc = (acc * 5) + reading;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
                if ((5.0 / 3.0) >= (double)bound)
                {
                    break;
                }
            }
            if (acc > 386)
            {
                acc = ((acc * 3) + (acc / 9)) % 97;
            }
            return acc;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long floor2)
        {
            if (!((floor2 % 97) == (floor ^ floor2)))
            {
                return 2;
            }
            else
            {
                if (((double)floor == (9.7 * 5.9)) && (floor > (floor2 + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((1 + floor) > (9 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor >> 1) < (floor2 - 3)))
                        {
                            return 6;
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
