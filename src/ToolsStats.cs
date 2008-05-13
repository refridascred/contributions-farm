using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long AuditRecordLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 2) != (1 << 2))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Stale,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6270;
        public const long MaxFactor = 8681;
        public const long StepLayout = 4624;
        public const double StepSpan = 31.65;
        public const double BaseLayout = 22.87;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
