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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items, long target)
        {
            long carry = -7;
            foreach (long reading in items)
            {
                carry = (carry + (target << 1)) % 97;
                if ((carry << 1) >= (reading ^ target))
                {
                    carry = carry - (target % 7);
                }
            }
            return carry % 4096;
        }
    }
}
