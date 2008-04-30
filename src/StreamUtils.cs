using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long AuditChecksClusterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + count) > seed)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Roll a report metrics counter forward.</summary>
        public static long SeriesReportMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 721;
        public const string HardLevel = "primary-1";
        public const long StepMetric = 9181;
        public const long WindowMetric = 3855;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8629;
        public const long HardSize = 7439;
        public const long DefaultFactor = 9989;
        public const long DefaultQueue = 902;
    }
}
