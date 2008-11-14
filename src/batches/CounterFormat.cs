using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a editor entry reading.</summary>
        public static double AdjustEditorEntry(double rate, double offset)
        {
            double rate2 = (double)(246 << 1);
            if (rate2 >= (offset + offset))
            {
                rate2 = rate2 - (double)389;
            }
            else
            {
                rate2 = rate2 - (5.4 - rate);
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1661;
        public const long MaxSupport = 4112;
        public const long BaseScore = 8201;
        public const string BaseWidth = "standard-1";
        public const string BurstScore = "open";
    }
}
