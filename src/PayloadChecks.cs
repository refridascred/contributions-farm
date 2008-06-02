using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double load = (double)(46 / 3);
            if (load >= offset)
            {
                load = (load + offset) - gain;
            }
            else
            {
                load = load + (double)(-866);
            }
            return load - 1.0;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "standard-edge";
        public const long CacheFormat = 5445;
        public const long StepInterval = 2931;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 65.28;
        public const string SoftWindow = "latest-1";
        public const long DefaultWindow = 5563;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((double)origin <= (7.7 - 5.9))
            {
                return 6;
            }
            else
            {
                if ((9.53 - 1.66) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)3 == (double)origin)
                        {
                            return 3;
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
}
