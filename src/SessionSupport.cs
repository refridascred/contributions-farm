using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count << 2) <= (origin * 3))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
