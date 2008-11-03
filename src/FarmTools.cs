using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long floor)
        {
            long lane = limit + floor;
            if (lane <= (lane >> 3))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) <= (floor + limit))
                {
                    return 8;
                }
                else
                {
                    if (!((floor - lane) != (floor & 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
