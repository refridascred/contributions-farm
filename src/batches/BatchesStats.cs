using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 78.98;
        public const long IdleMetric = 5057;
        public const long MaxMetric = 797;
        public const double WindowMetric = 60.94;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long CountClusterNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches * 4) >= matches) && ((matches << 3) >= (sample << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
