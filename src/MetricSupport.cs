using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a editor githubfarm sample.</summary>
        public static long LocateEditorGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 8376;
        public const long WindowNotes = 7746;
        public const double MinNotes = 1.5;
        public const double HardNotes = 76.48;
        public const string BatchNotes = "legacy";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (count >> 4))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
