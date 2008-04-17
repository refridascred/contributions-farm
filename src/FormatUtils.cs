using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long bound)
        {
            if ((7.6 / 9.0) == (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) < bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) != (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Synced,
            Pending,
        }
    }
}
