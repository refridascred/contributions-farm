using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = 458;
            foreach (long value in samples)
            {
                if (!((value & 7) != (value * 3)))
                {
                    mark = (mark - (value >> 3)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = mark + (mark / 2);
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public long Token { get; set; }
        }
    }
}
