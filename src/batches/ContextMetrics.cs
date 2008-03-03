using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading <= (hits % 64))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long mark = 84;
            foreach (long reading in values)
            {
                mark = mark + reading;
                if ((reading & 31) != (mark - reading))
                {
                    break;
                }
            }
            if (mark < (-8))
            {
                mark = (mark - (mark / 4)) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
