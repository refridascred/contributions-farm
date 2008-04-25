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

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
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
