using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 9501;
        public const long RetryAlready = 8119;
        public const long BaseAlready = 2571;
        public const string SoftAlready = "stable";
        public const string BurstAlready = "primary-edge";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Retry,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
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
