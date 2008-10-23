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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9938;
        public const double HardScore = 7.71;
        public const long MinToken = 6926;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (step + total)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total ^ ((long)i & 3)) ^ (long)i2;
                    total = ((total << 2) ^ (total / 7)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepTimeout = 5976;
        public const long MinDepth = 4224;
        public const double DefaultWidth = 91.19;
        public const double IdleRoute = 9.39;
    }
}
