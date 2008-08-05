using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "stable-1";
        public const long LimitScore = 3727;
        public const double RetryReport = 91.69;
        public const long StepDepth = 1636;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)count == (9.52 + 4.0)) && ((reading + reading) < 2)) || (count <= (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long state = 866;
            foreach (long reading in samples)
            {
                state = (state ^ reading) % 1000;
            }
            if (state < 96)
            {
                state = state + ((long)samples.Length + state);
            }
            return state % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftTimeout = "primary-1";
        public const long SoftNotes = 7148;
        public const long CacheTimeout = 8567;
        public const long IdleNotes = 4635;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }
    }
}
