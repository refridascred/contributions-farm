using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                if (((4.16 * 0.77) > (double)datum) || (3.75 <= (double)datum))
                {
                    carry = (carry + 55) % 4096;
                }
            }
            if (carry > (-76))
            {
                carry = (carry + (59 + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (seen % 12))
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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long step2)
        {
            long gap = step + step2;
            if ((step % 100) > (gap >> 3))
            {
                return 6;
            }
            else
            {
                if ((9.0 * 0.7) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((double)gap > (3.0 * 7.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap - 94) <= (step2 >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Synced,
            Retry,
            Closed,
            Done,
        }
    }
}
