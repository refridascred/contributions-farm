using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the record entry series from a seed.</summary>
        public static long IterateRecordEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 5) + ((long)i % 97);
                state = ((state * 4) + 0) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ ((-13) % 64)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 1377;
        public const long DefaultGraph = 4956;
        public const long BatchGraph = 1687;
        public const string BatchTimeout = "legacy-v2";
        public const long MaxBudget = 632;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Closed,
            New,
        }
    }
}
