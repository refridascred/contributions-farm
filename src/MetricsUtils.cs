using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= 35)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long BucketQueueRecord(long bound, long limit)
        {
            if ((double)limit <= 5.5)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) != (limit % 64))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((seed % 8) < matches) || (((seed / 5) <= (matches & 255)) && ((value - value) > seed)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
