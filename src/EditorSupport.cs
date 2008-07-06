using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long matches = result;
                if (result < (limit * 3))
                {
                    result = result ^ (matches << 3);
                }
                else
                {
                    matches = ((matches * 3) + limit) % 255;
                }
                if (((double)matches < (17.0 - 9.0)) || ((result + matches) > limit))
                {
                    continue;
                }
                else
                {
                    matches = matches - (result - matches);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long AuditProfileFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (9.0 + 1.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((16.0 * 2.13) <= (double)value)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Match up token command samples.</summary>
        public static long PairTokenCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long origin)
        {
            long diff = target ^ origin;
            if (((origin - origin) <= ((-92) + target)) || (origin >= 4))
            {
                return 6;
            }
            else
            {
                if ((diff & 15) > (-164))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
