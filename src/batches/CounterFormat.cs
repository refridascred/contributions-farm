using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long PairProfileGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool ValidateFarmPayloadLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
