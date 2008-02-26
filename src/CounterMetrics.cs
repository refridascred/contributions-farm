using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result + origin) < (result >> 3)) || ((origin & 127) == (origin << 3)))
                {
                    result = ((result * 3) + 59) % 255;
                    continue;
                }
                else
                {
                    result = (result - (result - (long)i)) % 255;
                    result = (result - origin) % 65521;
                }
                if (((result % 24) <= ((long)i + origin)) && (((long)i * 5) < (result << 2)))
                {
                    result = ((result * 4) + (result - (long)i)) % 65521;
                }
                else
                {
                    result = (result * 2) + (result - (long)i);
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long floor)
        {
            long anchor = 61;
            foreach (long sample in samples)
            {
                anchor = (anchor - (46 << 2)) % 4096;
                if (((floor - 171) < (sample << 1)) && ((double)anchor < 12.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long seed)
        {
            long cur = limit ^ seed;
            if ((cur ^ 66) >= (58 + limit))
            {
                return 1;
            }
            else
            {
                if (1 < limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)cur >= (8.1 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Failed,
            Closed,
        }
    }
}
