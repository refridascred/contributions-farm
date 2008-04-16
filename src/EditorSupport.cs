using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            if ((target << 2) > 158)
            {
                return 5;
            }
            else
            {
                if (((floor ^ floor) > floor) && (7.0 >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > 3.18)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + (-63)) < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long limit)
        {
            long acc = -829;
            foreach (long entry in data)
            {
                if ((limit <= (262 + limit)) && (6.9 > (double)entry))
                {
                    acc = ((acc * 3) + ((long)data.Length - 9)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + 8) != (floor - 43)))
                {
                    anchor = (anchor + ((long)i - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Done,
            New,
            Paused,
            Draft,
        }
    }
}
