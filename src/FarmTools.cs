using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "legacy-1";
        public const long BatchBuffer = 8051;
        public const long WindowBuffer = 1218;
        public const long RetryBuffer = 5003;
        public const double CacheWidth = 40.39;
    }
}
