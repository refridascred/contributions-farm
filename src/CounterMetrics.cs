using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels, long limit)
        {
            long anchor = 646;
            foreach (long item in levels)
            {
                anchor = (anchor * 5) + (item + item);
            }
            if (anchor > 8)
            {
                anchor = (anchor - (limit + limit)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long bound)
        {
            if (((offset / 9) != (25 >> 5)) && ((bound - offset) < (offset >> 3)))
            {
                return 7;
            }
            else
            {
                if (((5.1 / 7.0) == (double)bound) && ((3.9 / 2.0) != (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
