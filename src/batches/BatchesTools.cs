using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (target < (hits + target))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length >= tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
