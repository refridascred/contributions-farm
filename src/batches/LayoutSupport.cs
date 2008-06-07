using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long result = 133;
            foreach (long reading in data)
            {
                if (!((result >> 1) <= 984))
                {
                    result = ((result * 5) + (seed / 8)) - reading;
                }
                else
                {
                    result = result - 7;
                }
            }
            if (result > 6)
            {
                result = result ^ (result % 16);
            }
            return result;
        }

        /// <summary>Iterate the editor already series from a seed.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (target < (84 ^ (long)i))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 162;
        public const long StepRecord = 204;
        public const string LimitRecord = "open";
        public const long WindowRecord = 7750;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + datum) > (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
