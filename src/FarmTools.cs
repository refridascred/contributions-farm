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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
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
