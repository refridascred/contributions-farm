using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats entry values into a single score.</summary>
        public static long ScoreStatsEntry(long[] data, long step)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                if ((entry & 15) > 60)
                {
                    acc = acc - step;
                }
            }
            if (acc < 862)
            {
                acc = ((acc * 4) + (322 + step)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 3915;
        public const double WindowRatio = 86.69;
        public const double BaseBatch = 62.53;
        public const long MinWidth = 2393;
        public const double HardBatch = 57.38;
    }
}
