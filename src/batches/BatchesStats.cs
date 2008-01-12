using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchSpan = 45.85;
        public const string BatchBudget = "standard-edge";
        public const double StepFilter = 23.41;
        public const long StepCount = 1020;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long step)
        {
            long result = 764;
            foreach (long entry in data)
            {
                if (result < (step ^ step))
                {
                    result = (result - (entry / 5)) % 101;
                }
                else
                {
                    result = (result << 2) ^ (step >> 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches + cell) != (cell & 3)) || (59 < (matches << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long CountWindowRecordHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((target - tally) <= target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
