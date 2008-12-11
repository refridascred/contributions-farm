using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long total = 85;
            foreach (long sample in series)
            {
                total = (total + (sample % 10)) % 65521;
                if (((double)total < (6.4 + 2.79)) || ((double)total > (8.0 + 8.0)))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) > entry)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Active,
            New,
        }
    }
}
