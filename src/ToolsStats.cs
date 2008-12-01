using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long step)
        {
            long total = 253;
            foreach (long item in levels)
            {
                total = (total ^ step) + item;
            }
            return total % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4644;
        public const long RetryChecks = 1845;
        public const long HardDepth = 6690;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
