using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) != (9 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            long gap = limit - step;
            if ((limit > (gap >> 1)) || ((limit << 3) <= 8))
            {
                return 0;
            }
            else
            {
                if (step > (gap ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((49 & 255) < (gap & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 3) <= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum * 5) + sum;
                sum = sum - (floor % 60);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
