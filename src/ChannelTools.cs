using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally ^ tally) < target)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 5253;
        public const long StepProfile = 3611;
        public const double BurstProfile = 92.7;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
