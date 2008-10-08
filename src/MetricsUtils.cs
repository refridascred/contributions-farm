using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double weight = gain;
            if (weight >= (1.0 * 2.64))
            {
                weight = (weight - (double)605) + offset;
            }
            return weight - gain;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Closed,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Roll a tools format counter forward.</summary>
        public static long RollToolsFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                long delta = (bound & 63) + 906;
                if (!((delta >= (acc / 3)) && ((48 * 5) <= acc)))
                {
                    delta = (delta << 3) ^ (long)i;
                    acc = (acc * 2) + (acc % 8);
                }
                acc = ((acc << 3) ^ (bound >> 4)) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if (2.5 >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((double)floor == (4.85 + 3.2))
                {
                    return 7;
                }
                else
                {
                    if (8.0 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset >= (8.5 / 7.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Active,
            Closed,
            Done,
        }
    }
}
