using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a metric metrics reading by value.</summary>
        public static long SeekMetricMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long MeasureEditorSchemaGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seed < (long)samples.Length)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
