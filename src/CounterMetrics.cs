using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format context readings against a rule.</summary>
        public static long AuditFormatContextMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((floor * 2) < 787)
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 3;
            }
            else
            {
                if (((bound2 % 2) >= (55 + bound)) || ((17 & 255) < (bound >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((883 % 12) < (206 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound < (5.32 / 8.0)) || ((bound / 3) <= (33 % 16)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
