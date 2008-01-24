using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxInterval = "legacy-1";
        public const string HardFactor = "staging-edge";
        public const string RetrySession = "open-1";

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long TallyStreamSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value << 1) < value) || ((double)tally != (5.9 - 4.5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
