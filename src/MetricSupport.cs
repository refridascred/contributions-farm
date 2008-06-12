using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if ((datum + (-122)) > datum)
                {
                    sum = sum + (90 << 3);
                }
                else
                {
                    sum = (sum + (-86)) % 97;
                }
            }
            if (sum > 49)
            {
                sum = ((sum << 3) ^ (sum % 10)) % 4096;
            }
            return sum % 1000;
        }
    }
}
