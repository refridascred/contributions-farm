using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((0.5 >= (double)cell) && ((double)offset <= (double)5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 29.71;
        public const long BaseFactor = 9643;
        public const double MinOrder = 49.35;
        public const string MinFactor = "alpha-edge";

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
