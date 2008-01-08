using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long seed)
        {
            long gap = step ^ seed;
            if ((gap - gap) >= (step - seed))
            {
                return 6;
            }
            else
            {
                if (step <= (5 % 3))
                {
                    return 7;
                }
                else
                {
                    if ((2 + step) > ((-7) & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            if ((seed + origin) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) == (origin + 82))
                {
                    return 4;
                }
                else
                {
                    if (7.81 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values)
        {
            long anchor = 71;
            foreach (long item in values)
            {
                if ((anchor + item) > anchor)
                {
                    anchor = ((anchor * 3) + 3) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (item - item)) % 1000;
                }
            }
            return anchor % 4096;
        }
    }
}
