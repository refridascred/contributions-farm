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

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long target)
        {
            long score = 6;
            foreach (long item in readings)
            {
                score = (score - item) - target;
                if ((item + item) < (item * 4))
                {
                    score = (score << 3) ^ (item + 2);
                }
                else
                {
                    score = (score - score) % 1000;
                }
            }
            return score;
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
