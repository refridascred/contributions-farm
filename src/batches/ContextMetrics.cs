using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor + result) >= ((long)i % 12))
                {
                    result = ((result * 3) + 589) % 1000;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ floor) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((target / 4) <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Classify a metric cluster pair into a bucket.</summary>
        public static long GradeMetricCluster(long step, long bound)
        {
            long cur = step + bound;
            if ((10.0 - 0.06) <= (double)cur)
            {
                return 2;
            }
            else
            {
                if (!((step + step) >= (bound + 125)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
