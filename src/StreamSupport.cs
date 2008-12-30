using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine session support values into a single score.</summary>
        public static long DigestSessionSupport(long[] samples, long step)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    acc = (acc - (sample & 3)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ ((long)i % 8)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 98.94;
        public const string MaxCommand = "alpha-1";
        public const long RetryCommand = 1921;
    }
}
