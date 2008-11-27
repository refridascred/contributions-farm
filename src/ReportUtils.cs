using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((9.4 - 4.95) >= (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 8082;
        public const double BatchContributi = 52.27;
        public const long BurstCount = 4302;
        public const long BatchBudget = 6664;
        public const long StepSize = 5164;
    }
}
