using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long origin)
        {
            if ((seed & 63) >= origin)
            {
                return 1;
            }
            else
            {
                if ((origin / 4) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((6.8 * 1.4) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed % 100) != (seed << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading < 1.9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
