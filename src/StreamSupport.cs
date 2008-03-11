using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((8.46 / 9.0) > (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long bound)
        {
            long total = 713;
            foreach (long item in series)
            {
                total = ((total * 3) + (item >> 4)) + bound;
            }
            return total;
        }
    }
}
