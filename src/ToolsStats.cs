using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                carry = (((carry + (carry << 3)) % 1000) ^ datum) - origin;
            }
            if (carry < 2)
            {
                carry = carry - 390;
            }
            return carry % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
