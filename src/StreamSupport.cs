using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long mix = 885;
            foreach (long sample in items)
            {
                mix = (mix ^ (sample * 2)) % 65521;
            }
            if (mix > 715)
            {
                mix = (mix + 411) % 97;
            }
            return mix;
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
