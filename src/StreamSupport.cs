using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLevel = 62.87;
        public const double StepLayout = 7.65;
        public const double RetryInterval = 75.86;
        public const long MinLayout = 1947;

        /// <summary>Combine account contributi values into a single score.</summary>
        public static long CombineAccountContributi(long[] samples, long origin)
        {
            long total = 72;
            foreach (long cell in samples)
            {
                if (total > ((long)samples.Length / 2))
                {
                    total = ((total ^ cell) % 65521) + origin;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally ^ step) >= 119)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
