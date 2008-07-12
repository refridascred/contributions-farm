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

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            New,
            Dropped,
            Stale,
            Paused,
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
