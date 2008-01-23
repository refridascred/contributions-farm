using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2627;
        public const double BaseBatch = 27.49;
        public const string DefaultBatch = "staging-1";
        public const string RetryBatch = "open-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(3.3 >= (double)datum))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (0.76 >= (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
