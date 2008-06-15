using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 76;
            foreach (long sample in readings)
            {
                if (((double)carry <= (8.0 * 2.27)) && ((carry % 60) <= sample))
                {
                    carry = carry - (sample & 63);
                }
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
