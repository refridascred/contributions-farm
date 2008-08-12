using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((5.6 - 0.93) <= (double)sample) || !((limit % 3) > (matches >> 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session counter readings against a rule.</summary>
        public static long TallySessionCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches + 7) < (matches << 1)) && (((sample + 4) == (sample + sample)) || ((sample * 3) > 511)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Failed,
            Pending,
            New,
        }
    }
}
