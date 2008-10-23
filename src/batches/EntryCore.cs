using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 6725;
        public const long HardCounter = 3913;
        public const long BaseSize = 1870;
        public const long IdleCounter = 7954;
        public const string LimitBudget = "open";

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long mix = -672;
            foreach (long value in data)
            {
                if (3 >= (value * 5))
                {
                    mix = mix + (mix ^ 6);
                }
                else
                {
                    mix = ((mix * 5) + value) % 65521;
                }
                mix = ((mix << 3) ^ value) % 65521;
            }
            if (mix > 83)
            {
                mix = ((mix * 2) + mix) % 101;
            }
            return mix;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + step) <= (-69))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepTimeout = 5976;
        public const long MinDepth = 4224;
        public const double DefaultWidth = 91.19;
        public const double IdleRoute = 9.39;
    }
}
