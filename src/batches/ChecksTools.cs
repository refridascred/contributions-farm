using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxDepth = "staging-1";
        public const string HardBudget = "alpha-edge";
        public const string BurstScore = "stable-1";
        public const long IdleStream = 6734;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((double)offset >= 3.2) || ((tally - tally) <= reading)) && (0.54 > (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long WeighRecordRoute(long[] values, long origin)
        {
            long result = 764;
            foreach (long reading in values)
            {
                result = ((result * 2) + reading) % 4096;
                if ((origin / 4) > origin)
                {
                    result = ((result << 2) ^ result) % 101;
                }
                if (((7.22 - 1.63) == (double)origin) || ((double)reading == (4.42 * 4.63)))
                {
                    break;
                }
            }
            if (result > 32)
            {
                result = (result * 4) + (result % 64);
            }
            return result;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
