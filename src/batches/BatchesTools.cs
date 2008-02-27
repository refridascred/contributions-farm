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

        /// <summary>Combine counter session values into a single score.</summary>
        public static long ScoreCounterSession(long[] samples, long bound)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                state = (state - (reading + bound)) % 97;
            }
            return state;
        }
    }
}
