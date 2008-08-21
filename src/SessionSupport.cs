using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window record counter forward.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((long)i <= limit))
                {
                    state = (state << 3) ^ ((long)i % 60);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
