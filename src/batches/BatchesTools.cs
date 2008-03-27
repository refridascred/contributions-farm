using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long limit, long origin)
        {
            if (limit < (origin % 60))
            {
                return 8;
            }
            else
            {
                if ((limit + 93) <= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if ((17.0 - 12.0) >= (13.0 + 0.7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.97 - 7.93) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
