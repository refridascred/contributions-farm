using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value <= (seen + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long bound)
        {
            long total = 94;
            foreach (long datum in levels)
            {
                total = total - (-4);
                if (((total & 255) >= (datum + datum)) || ((total + total) <= bound))
                {
                    break;
                }
            }
            return total;
        }
    }
}
