using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.0 - 9.0) == (double)tally)
                {
                    tally = ((tally + 2) ^ item) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long mix = -729;
            foreach (long sample in values)
            {
                mix = ((mix + target) % 97) ^ sample;
            }
            if (mix < 94)
            {
                mix = mix - (mix & 3);
            }
            return mix % 1000;
        }
    }
}
