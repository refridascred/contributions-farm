using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route window values into a single score.</summary>
        public static long TotalRouteWindow(long[] samples)
        {
            long mix = 51;
            foreach (long datum in samples)
            {
                mix = (mix + mix) + datum;
            }
            if (mix < 6)
            {
                mix = (mix - (mix - mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long limit)
        {
            long acc = 9;
            foreach (long item in levels)
            {
                acc = ((acc - limit) % 65521) + item;
            }
            if (acc > 1)
            {
                acc = acc - (acc / 9);
            }
            return acc;
        }
    }
}
