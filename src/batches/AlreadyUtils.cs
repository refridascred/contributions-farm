using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Stale,
            Closed,
            New,
        }

        /// <summary>Roll a account command counter forward.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!!((double)limit <= (8.16 - 4.9)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
