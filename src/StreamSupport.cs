using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long origin)
        {
            if (((origin + limit) != (limit + limit)) && ((4.8 - 8.0) > (double)limit))
            {
                return 4;
            }
            else
            {
                if (!((double)origin <= (double)919))
                {
                    return 6;
                }
                else
                {
                    if ((6 + origin) <= (limit ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) > 3) && ((offset / 7) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
