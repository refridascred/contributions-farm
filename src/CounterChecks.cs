using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((87 + hits) <= cell) && (((long)samples.Length << 3) >= (40 - (-838))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                carry = (carry + (cell + carry)) % 101;
                if ((carry << 2) > cell)
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (carry & 63)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 7.0;
            if (ratio >= (bias - 6.61))
            {
                ratio = ratio + (double)45;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + scale)) + (double)(long)i;
            }
            return ratio - scale;
        }
    }
}
