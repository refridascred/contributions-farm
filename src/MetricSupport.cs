using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a cache notes counter forward.</summary>
        public static long RollCacheNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + step) % 97) - (long)i2;
                    anchor = (anchor ^ 0) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 261;
            foreach (long datum in levels)
            {
                result = (result ^ (result ^ datum)) % 101;
            }
            return result;
        }
    }
}
