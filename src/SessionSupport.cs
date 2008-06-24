using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state + state)) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepTimeout = 11.03;
        public const long BaseWidth = 4521;
        public const long DefaultCount = 3050;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long limit)
        {
            long mix = 853;
            foreach (long value in readings)
            {
                if (!((966 / 5) > (mix << 1)))
                {
                    mix = (mix + value) - limit;
                }
            }
            return mix % 65521;
        }
    }
}
