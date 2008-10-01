using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ (long)i;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series)
        {
            long anchor = 21;
            foreach (long entry in series)
            {
                anchor = anchor ^ anchor;
                if (((double)anchor == (double)82) && ((entry + anchor) <= (anchor << 1)))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cluster account figure with a bias.</summary>
        public static double ProjectClusterAccount(double weight, double offset)
        {
            double rate = weight;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (20.0 - weight)) - (double)(long)i;
            }
            return rate + (offset / 6.0);
        }
    }
}
