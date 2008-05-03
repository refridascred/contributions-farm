using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long limit)
        {
            long span = floor - limit;
            if ((span >> 1) < (span - 783))
            {
                return 2;
            }
            else
            {
                if ((980 & 31) != (limit << 1))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 63) >= (matches << 1)) && ((matches / 4) == (3 - datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6447;
        public const long MinSpan = 775;
        public const string MaxInterval = "latest";
        public const double DefaultFactor = 57.84;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
