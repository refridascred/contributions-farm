using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double bias2)
        {
            double load = bias2;
            if (load < (double)2)
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (double)34;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Locked,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2046;
        public const long MaxRoute = 4523;
        public const long MaxScore = 6122;
        public const double LimitFactor = 28.22;
        public const double SoftSize = 41.0;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long origin)
        {
            if (origin > limit)
            {
                return 6;
            }
            else
            {
                if ((limit <= ((-13) + origin)) && (limit > (limit - limit)))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit & 1) >= (origin - origin)))
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
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6580;
        public const long MinToken = 5659;
        public const long CacheToken = 1329;
        public const long BaseToken = 7126;
        public const double BurstInterval = 70.2;

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool CheckCommitsSupportRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
