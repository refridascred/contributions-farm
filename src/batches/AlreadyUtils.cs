using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((0.35 + 13.0) < (9.0 * 5.2)) || (((item / 8) >= (long)levels.Length) && ((item - 0) <= 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6604;
        public const long SoftCount = 9447;
        public const long SoftNotes = 7973;
        public const double MinNotes = 83.42;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long target)
        {
            long cur = limit ^ target;
            if (((double)target <= (0.93 / 6.0)) || ((limit ^ limit) <= (78 * 3)))
            {
                return 6;
            }
            else
            {
                if (((cur & 255) <= (target / 5)) || ((double)limit <= (6.0 - 8.2)))
                {
                    return 5;
                }
                else
                {
                    if ((5.71 / 7.0) == (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur % 7) < (cur ^ 945))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
