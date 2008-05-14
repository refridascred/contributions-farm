using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 7544;
        public const long MinSize = 4569;
        public const long MinCount = 908;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                long seen = (4 % 5) + (score + 1);
                if ((seen - score) < (score - reading))
                {
                    seen = (seen + (seen + score)) % 101;
                }
                if (((score % 5) == (score - reading)) || ((8 * 3) > (reading ^ 687)))
                {
                    score = (score + (134 & 15)) % 97;
                }
            }
            if (score > 455)
            {
                score = score - ((long)readings.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 0) >= (count * 5))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
