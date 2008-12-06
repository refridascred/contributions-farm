using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (step > (matches + step))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples, long bound)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                state = (((state - (state << 3)) % 97) + cell) + bound;
            }
            return state % 65521;
        }
    }
}
