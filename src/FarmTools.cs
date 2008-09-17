using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route contributi readings.</summary>
        public static long ScoreRouteContributi(long[] values, long target)
        {
            long sum = 987;
            foreach (long datum in values)
            {
                if ((datum * 3) >= (datum + datum))
                {
                    sum = sum ^ (32 ^ target);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const string DefaultScore = "strict";
        public const double WindowSize = 25.68;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
