using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally << 2) >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long bound)
        {
            if (!((offset + offset) > (28 ^ bound)))
            {
                return 5;
            }
            else
            {
                if (!((bound >> 3) >= (offset >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSpan = 9856;
        public const long StepBudget = 8965;
        public const string MaxFactor = "open";
        public const long DefaultRoute = 1222;
    }
}
