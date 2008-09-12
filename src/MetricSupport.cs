using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long result = -575;
            foreach (long sample in samples)
            {
                result = (result ^ (sample - (-5))) % 1000;
                result = (result - (result + result)) % 255;
                if ((bound / 4) <= (sample % 7))
                {
                    result = ((result * 4) + bound) % 4096;
                }
            }
            if (result < 8)
            {
                result = ((result * 5) + (result >> 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Count the editor commits entries that pass the check.</summary>
        public static long MeasureEditorCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item >= (7.0 - 2.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
