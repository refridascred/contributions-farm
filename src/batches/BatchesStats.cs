using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (bound < (count + 2))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + sample) > sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long limit)
        {
            long anchor = 22;
            foreach (long reading in values)
            {
                anchor = ((anchor - 0) ^ reading) - limit;
            }
            if (anchor > (-981))
            {
                anchor = (anchor - ((-625) / 2)) % 101;
            }
            return anchor % 4096;
        }
    }
}
