using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long target)
        {
            if ((seed > (seed + seed)) || (seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
