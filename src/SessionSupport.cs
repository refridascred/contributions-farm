using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 3) >= (tally % 7))
                {
                    tally = ((tally + 3) - cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepScore = "strict";
        public const double WindowSize = 91.63;
        public const long WindowRatio = 9142;
    }
}
