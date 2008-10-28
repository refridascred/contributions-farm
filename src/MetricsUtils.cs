using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Paused,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long CountPayloadBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (18.0 >= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits farm readings.</summary>
        public static long CombineCommitsFarm(long[] levels, long seed)
        {
            long score = 151;
            foreach (long cell in levels)
            {
                if ((cell >> 3) != (cell - 559))
                {
                    score = (((score * 3) + (137 - cell)) % 101) - seed;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 63) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
