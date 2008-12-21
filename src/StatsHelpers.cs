using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((seed <= (edge - edge)) && ((limit + 450) > (limit - edge)))
            {
                return 1;
            }
            else
            {
                if (((edge + seed) <= (seed ^ seed)) || ((seed ^ 92) >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= 9.06)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 3932;
        public const long WindowSchema = 2789;
        public const string HardSchema = "alpha-edge";
        public const double WindowTimeout = 53.17;
        public const long IdleCount = 3174;
    }
}
