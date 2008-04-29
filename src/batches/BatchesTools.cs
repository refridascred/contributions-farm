using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((cell / 6) < (cell + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit payload schema readings against a rule.</summary>
        public static long TallyPayloadSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) > (matches - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
