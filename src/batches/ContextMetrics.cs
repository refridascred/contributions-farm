using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series)
        {
            long anchor = 18;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading + 40)) % 65521;
            }
            if (anchor < 49)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long MeasureSupportWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!!(7.09 < (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            New,
        }
    }
}
