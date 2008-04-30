using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long target)
        {
            long score = 2;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (target % 12)) + sample;
                if ((target << 3) <= 8)
                {
                    score = ((score << 2) ^ (score & 7)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LocateRecordPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
