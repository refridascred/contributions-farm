using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample << 1) < (802 ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
