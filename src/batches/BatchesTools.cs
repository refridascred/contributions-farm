using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            New,
            Paused,
            Ready,
            Failed,
        }
    }
}
