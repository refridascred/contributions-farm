using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long mark = 50;
            foreach (long item in series)
            {
                mark = ((mark + (target + target)) % 101) + item;
            }
            return mark % 97;
        }
    }
}
