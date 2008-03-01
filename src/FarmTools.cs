using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long limit)
        {
            long carry = 187;
            foreach (long cell in items)
            {
                carry = ((carry << 2) ^ (limit + 194)) % 65521;
                if (((carry / 4) < (cell % 2)) && ((carry + limit) > 176))
                {
                    carry = (carry + carry) % 101;
                }
                if ((3.04 - 4.2) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
