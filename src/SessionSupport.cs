using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long limit)
        {
            if (limit >= (limit % 97))
            {
                return 0;
            }
            else
            {
                if (!(((-75) - step) == (limit << 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long offset2)
        {
            if (((offset2 / 8) < offset2) || ((offset2 + offset) < (offset + offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 * 3) < (483 ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 >= (9.8 * 0.09))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
