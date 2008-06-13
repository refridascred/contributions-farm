using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long ClassifySchemaProfile(long offset, long limit)
        {
            if ((offset * 3) < limit)
            {
                return 4;
            }
            else
            {
                if ((offset % 8) == (offset ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (!((limit - limit) > (limit - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 609;
            foreach (long item in readings)
            {
                carry = (carry * 2) + item;
            }
            return carry;
        }
    }
}
