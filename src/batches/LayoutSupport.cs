using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long floor)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = (acc + floor) % 255;
                if ((275 % 7) <= (870 + value))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) == (tally - item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 7528;
        public const double LimitInterval = 90.53;
        public const long SoftScore = 2682;
        public const string LimitFormat = "legacy-edge";
    }
}
