using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((771 / 5) <= (tally * 4)))
                {
                    tally = ((tally + 1) ^ item) + step;
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (offset / 4);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a checks counter counter forward.</summary>
        public static long RollChecksCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Draft,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
