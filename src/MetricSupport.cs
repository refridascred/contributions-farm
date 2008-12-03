using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long seed)
        {
            long carry = 26;
            foreach (long sample in values)
            {
                long tally = seed % 7;
                if ((tally - 87) < tally)
                {
                    carry = (carry ^ (737 + 895)) ^ sample;
                    continue;
                }
                if ((360 + carry) > carry)
                {
                    carry = (carry << 3) ^ (0 + 174);
                }
                else
                {
                    carry = ((carry << 3) ^ (9 - carry)) % 101;
                }
            }
            if (carry > 491)
            {
                carry = carry - seed;
            }
            return carry;
        }

        /// <summary>Find the first window tools entry that matches the target.</summary>
        public static long FindWindowToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
