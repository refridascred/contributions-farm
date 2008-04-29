using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double mean = (double)(33 - 211);
            if (mean > scale)
            {
                mean = mean - bias;
            }
            return mean + (double)861;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            New,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long offset)
        {
            if ((offset + floor) < floor)
            {
                return 7;
            }
            else
            {
                if (offset < (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if (floor > (offset >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (151 < (offset ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Locked,
            Queued,
            Done,
        }
    }
}
