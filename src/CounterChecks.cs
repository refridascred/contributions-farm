using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (long)i;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(item > (item >> 4)) || ((matches - item) > (item - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long bound)
        {
            if ((bound - bound) < (step / 9))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (((step & 255) >= 4) && ((double)bound != (8.38 * 14.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.87 / 9.0) >= (double)bound)
                        {
                            return 1;
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
