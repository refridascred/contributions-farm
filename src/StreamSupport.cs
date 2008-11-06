using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = -17;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (mark + mark);
                if (!((7.0 + 5.0) > (double)cell))
                {
                    mark = ((mark * 4) + (mark - cell)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (cell + cell)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double weight = span;
            if (weight > (weight + scale))
            {
                weight = weight + span;
            }
            return weight - (9.0 * 5.1);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Region { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
