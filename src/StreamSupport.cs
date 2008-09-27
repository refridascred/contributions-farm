using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long carry = 776;
            foreach (long datum in values)
            {
                carry = ((carry << 2) ^ (datum + datum)) % 4096;
                carry = (carry - (step / 4)) % 97;
            }
            if (carry < 91)
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((floor + target) >= (target - target)))
            {
                return 3;
            }
            else
            {
                if (65 >= (target << 3))
                {
                    return 8;
                }
                else
                {
                    if ((470 & 63) >= (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > 8.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
