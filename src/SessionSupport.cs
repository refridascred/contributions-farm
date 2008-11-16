using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long floor)
        {
            if ((double)floor <= 7.0)
            {
                return 3;
            }
            else
            {
                if (limit >= (78 + 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long MatchSessionPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
