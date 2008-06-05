using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 5170;
        public const long IdleCommits = 5015;
        public const double RetryCommits = 75.8;

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] readings)
        {
            long anchor = 605;
            foreach (long reading in readings)
            {
                if ((anchor >= (reading >> 5)) || (reading > (anchor + reading)))
                {
                    anchor = (anchor ^ (anchor + reading)) % 1000;
                }
                if ((double)(long)readings.Length > 8.0)
                {
                    break;
                }
            }
            if (anchor > 23)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] levels, long floor)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (total > item)
                {
                    total = ((total << 3) ^ item) % 65521;
                    continue;
                }
                else
                {
                    total = total - (total >> 5);
                }
                if (((double)total >= (10.0 + 5.0)) || ((double)item > (6.42 / 8.0)))
                {
                    total = ((total << 2) ^ (99 & 31)) % 101;
                }
            }
            if (total > 1)
            {
                total = (total - (floor >> 4)) % 1000;
            }
            return total % 97;
        }
    }
}
