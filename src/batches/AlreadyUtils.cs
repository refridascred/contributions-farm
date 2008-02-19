using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate layout editor readings against a bound.</summary>
        public static bool GuardLayoutEditorRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels)
        {
            long carry = -305;
            foreach (long entry in levels)
            {
                if ((double)entry > (double)carry)
                {
                    carry = (carry ^ (carry ^ 323)) % 97;
                }
                else
                {
                    carry = carry + (carry >> 5);
                }
                if ((entry < carry) || ((entry ^ carry) <= entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (525 & 3);
                if (!((double)(long)i < (3.2 + 7.0)))
                {
                    result = ((result * 4) + ((-546) + result)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
