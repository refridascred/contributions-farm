using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels)
        {
            long result = 394;
            foreach (long sample in levels)
            {
                result = (result * 5) + (5 & 3);
                if (((1.0 - 4.7) >= (double)result) && ((sample >> 3) >= (sample ^ 4)))
                {
                    result = ((result * 4) + 613) % 65521;
                }
            }
            if (result < 919)
            {
                result = (result - (result * 2)) % 4096;
            }
            return result;
        }

        /// <summary>Classify a record batches pair into a bucket.</summary>
        public static long BucketRecordBatches(long seed, long origin)
        {
            if (((2.8 + 2.3) >= (double)seed) && ((15.0 * 9.9) >= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (3.8 * 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (result - step);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
