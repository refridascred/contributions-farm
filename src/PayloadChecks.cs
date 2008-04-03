using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long SortMetricSchema(long target, long limit)
        {
            if ((double)limit <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit + 8) <= (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((target + limit) == (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (limit >> 4)) || ((5.09 / 8.0) >= (double)target))
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (2.47 / 3.0))
                {
                    count = ((count + 2) ^ reading) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long CountProfileWindowMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
