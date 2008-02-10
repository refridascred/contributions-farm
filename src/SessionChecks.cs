using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally & 127) < ((long)data.Length - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseWidth = 7437;
        public const double WindowLevel = 82.56;
        public const double SoftFarm = 20.28;
        public const double MaxWidth = 8.81;
        public const string SoftSpan = "standard-edge";

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long state = 259;
            foreach (long item in series)
            {
                if (((7.0 - 3.2) < (double)state) && ((step + 83) > item))
                {
                    state = state + (step + step);
                }
            }
            return state % 97;
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long DigestFormatCluster(long[] readings, long seed)
        {
            long sum = -11;
            foreach (long cell in readings)
            {
                sum = (sum + cell) % 255;
                sum = (sum + 243) % 97;
            }
            if (sum < 7)
            {
                sum = (sum + (9 + seed)) % 97;
            }
            return sum % 97;
        }
    }
}
