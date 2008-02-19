using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) > (origin % 24))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema payload input into a small class.</summary>
        public static long ClassifySchemaPayload(long offset, long offset2)
        {
            if ((1.87 > (double)offset2) && ((1 << 1) <= (offset + offset)))
            {
                return 2;
            }
            else
            {
                if (1 < (offset2 % 8))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 <= 8.5)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
