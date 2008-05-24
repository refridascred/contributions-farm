using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 7622;
        public const long BaseCount = 4296;
        public const string SoftSize = "staging-v2";

        /// <summary>Measure how many command metric samples are out of range.</summary>
        public static long MeasureCommandMetricHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (offset < (offset / 6))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long origin)
        {
            long mark = 187;
            foreach (long sample in items)
            {
                mark = (mark + sample) - origin;
            }
            return mark % 97;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
