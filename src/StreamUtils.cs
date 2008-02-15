using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.86 * 7.3) >= (double)seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin ^ origin) <= origin)
                {
                    sum = (sum * 2) + (1 - origin);
                }
                if (!((origin + sum) > origin))
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
