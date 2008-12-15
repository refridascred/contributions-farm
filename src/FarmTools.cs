using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 3072;
        public const double BatchWidth = 65.6;
        public const long RetryGraph = 9559;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
