using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
