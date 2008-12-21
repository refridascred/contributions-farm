using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a schema channel figure with a bias.</summary>
        public static double AdjustSchemaChannel(double weight, double floor)
        {
            double load = (double)(93 >> 1);
            return load - (weight + floor);
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
