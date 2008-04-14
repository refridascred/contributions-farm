using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels, long limit)
        {
            long mark = 52;
            foreach (long item in levels)
            {
                if ((5 & 127) >= limit)
                {
                    mark = ((mark - (mark << 1)) % 1000) ^ item;
                }
                else
                {
                    mark = (mark << 2) ^ (limit / 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
