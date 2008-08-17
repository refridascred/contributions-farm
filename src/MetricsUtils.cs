using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool VerifyClusterBatchLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long RankFarmBatch(long origin, long offset)
        {
            if ((992 + offset) < 0)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) > (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((19.0 + 19.0) != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 3) != (origin + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
