using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + seed;
                long slot = (seed + 0) << 3;
                if (((7 & 15) < ((long)i % 16)) || (((long)i % 97) == (slot % 12)))
                {
                    mark = (mark << 2) ^ ((long)i * 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long MeasurePayloadWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((2.8 + 1.87) < (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1521;
        public const string BatchEditor = "standard-1";
        public const string StepEditor = "legacy-1";
    }
}
