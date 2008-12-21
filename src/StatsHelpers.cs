using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long carry = 40;
            foreach (long entry in data)
            {
                if ((0 + entry) >= (entry * 2))
                {
                    carry = ((carry << 3) ^ 213) % 97;
                }
                else
                {
                    carry = (carry + carry) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - ((long)i / 9)) % 97;
                long diff = (target + (long)i) + target;
                anchor = anchor - (target + diff);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
