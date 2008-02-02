using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up already graph samples.</summary>
        public static long MatchAlreadyGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (18.0 >= (double)(long)i)
                {
                    anchor = anchor + (limit - 22);
                }
                else
                {
                    anchor = (anchor + (anchor ^ 950)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 301;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (22 >> 1))
                {
                    carry = carry ^ (entry - (-25));
                }
                carry = (carry << 3) ^ (entry + carry);
                if ((carry / 3) < (long)levels.Length)
                {
                    carry = (carry ^ entry) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry << 1)) % 255;
                }
                if (!(carry >= 86))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
