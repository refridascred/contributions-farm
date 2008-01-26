using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long limit)
        {
            long delta = floor + limit;
            if (((floor >> 3) > 2) || (2 <= (delta * 3)))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) == (floor * 3)) && ((delta * 2) < (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the format entry series from a seed.</summary>
        public static long StepFormatEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = total + (long)i;
                if ((double)total >= (double)offset)
                {
                    total = ((total << 3) ^ (offset - total)) % 1000;
                }
                else
                {
                    total = (total ^ (total / 7)) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] series)
        {
            long acc = 401;
            foreach (long sample in series)
            {
                if (acc <= (acc >> 3))
                {
                    acc = (acc - (928 + sample)) % 101;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 2) ^ (acc ^ acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
