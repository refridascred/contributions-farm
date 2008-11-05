using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long offset2)
        {
            long diff = offset - offset2;
            if ((offset * 3) > (offset2 - offset))
            {
                return 8;
            }
            else
            {
                if (((offset + diff) <= diff) && ((offset2 / 8) < offset2))
                {
                    return 2;
                }
                else
                {
                    if ((offset > offset2) || ((offset - offset) >= (diff ^ diff)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long limit)
        {
            if ((57 * 4) <= (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit - 6) > (step - limit))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) < (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
