using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally >= (datum ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a cluster counter value against two limits.</summary>
        public static long ClassifyClusterCounter(long floor, long limit)
        {
            if ((floor >= (floor / 9)) || ((992 / 5) <= (floor - limit)))
            {
                return 4;
            }
            else
            {
                if ((2.0 >= (double)floor) && ((2.2 + 5.0) != (double)limit))
                {
                    return 6;
                }
                else
                {
                    if (((double)floor != (4.0 / 5.0)) || ((4 + floor) >= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 4) <= (limit / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
