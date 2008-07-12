using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Pending,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Look up the position of a buffer commits sample.</summary>
        public static long SeekBufferCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry & 63) == (560 % 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long RollCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((mix >> 5) < ((long)i + bound))
                {
                    mix = (mix ^ bound) % 255;
                    mix = mix ^ (mix % 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long target)
        {
            if (((origin - 77) > (target * 4)) && ((6.3 - 9.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((target >> 2) <= (origin + 1))
                {
                    return 3;
                }
                else
                {
                    if ((6.9 - 16.0) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
