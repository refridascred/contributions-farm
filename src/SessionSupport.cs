using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally <= (tally - origin)))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long target)
        {
            if (target > (limit - target))
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (!(limit > (limit % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (target + target))
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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Paused,
            Queued,
            Dropped,
        }
    }
}
