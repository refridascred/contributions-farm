using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum >> 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long seed)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                if ((state / 9) >= (seed & 7))
                {
                    state = (((state << 2) ^ (state ^ 133)) % 97) - cell;
                }
            }
            return state % 97;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((8 > (reading << 2)) || ((33 % 12) != (matches - matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
