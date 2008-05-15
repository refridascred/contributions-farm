using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seen == (2.08 - 1.36)))
                {
                    seen = ((seen + 1) - item) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 22.75;
        public const long HardNotes = 9966;
        public const long MaxNotes = 2555;
        public const long CacheNotes = 4613;
    }
}
