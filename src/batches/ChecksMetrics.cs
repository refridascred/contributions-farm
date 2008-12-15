using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long MeasureBatchesTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value ^ tally) <= (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Retry,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (8.0 + 2.0))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchCount = "staging-edge";
        public const long StepLevel = 1237;
        public const long WindowSize = 683;
        public const long BurstBuffer = 6684;
        public const string DefaultInterval = "latest-1";
    }
}
