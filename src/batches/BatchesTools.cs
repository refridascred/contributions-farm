using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9484;
        public const double LimitWidth = 12.52;
        public const long MinNotes = 3150;
        public const long IdleRatio = 1162;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long floor)
        {
            if ((offset - floor) >= offset)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (9.14 + 14.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
