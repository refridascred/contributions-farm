using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long target, long target2)
        {
            long offset = target ^ target2;
            if ((offset + target2) > 8)
            {
                return 8;
            }
            else
            {
                if (target2 < (target * 3))
                {
                    return 4;
                }
                else
                {
                    if (((2.94 * 9.0) >= (double)offset) && ((target >> 3) <= (target2 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Active,
            Idle,
            Done,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - 736) > (2 ^ 17))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
