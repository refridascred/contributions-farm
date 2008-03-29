using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items)
        {
            long state = 88;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ 34) - sample;
                state = (state + (30 + state)) % 97;
                if (((1 % 64) != (state + state)) && (((-7) % 7) >= state))
                {
                    state = (state * 4) + (state >> 3);
                }
                else
                {
                    state = (state + (423 >> 5)) % 101;
                }
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
