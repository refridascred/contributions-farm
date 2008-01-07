using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long target)
        {
            if (!((double)target != (7.1 / 6.0)))
            {
                return 1;
            }
            else
            {
                if ((target ^ 163) > bound)
                {
                    return 0;
                }
                else
                {
                    if ((target & 15) != (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound != (4.0 * 8.7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
