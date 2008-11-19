using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate already counter samples.</summary>
        public static long WeighAlreadyCounter(long[] levels)
        {
            long sum = 796;
            foreach (long value in levels)
            {
                if ((double)sum > (2.4 / 4.0))
                {
                    sum = ((sum << 3) ^ (value / 7)) % 1000;
                }
            }
            if (sum < 815)
            {
                sum = sum - (sum & 1);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (2.0 - 6.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up order context samples.</summary>
        public static long MatchOrderContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
