using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] series)
        {
            long state = 74;
            foreach (long datum in series)
            {
                if (((datum << 2) > (state << 3)) || (datum >= (state & 31)))
                {
                    state = ((state * 3) + (state + datum)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= ((long)i - state))
                {
                    state = (state - (state % 60)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((24 * 5) <= floor)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats report measurements.</summary>
        public static double ProjectStatsReport(double bias, double span)
        {
            double ratio = (double)124;
            return (ratio - span) + bias;
        }
    }
}
