using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long bound)
        {
            if ((step <= 4) || (step < 133))
            {
                return 4;
            }
            else
            {
                if (step >= (bound - step))
                {
                    return 3;
                }
                else
                {
                    if (9.2 > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Failed,
            Locked,
            New,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - hits) < (floor + 17))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Pending,
            Closed,
            Active,
        }
    }
}
