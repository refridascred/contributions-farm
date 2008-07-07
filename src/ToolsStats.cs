using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items, long target)
        {
            long result = 33;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ 22) % 97;
                if (((reading ^ target) > target) && ((4 / 2) <= target))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            long next = origin ^ seed;
            if (next >= origin)
            {
                return 4;
            }
            else
            {
                if ((seed % 60) == ((-49) + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + seed) <= 43))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= (next ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
