using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                acc = (acc * 3) + (entry & 255);
            }
            return acc;
        }

        /// <summary>Look up the position of a editor notes sample.</summary>
        public static long FindEditorNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
