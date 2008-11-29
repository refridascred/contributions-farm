using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools order input into a small class.</summary>
        public static long ClassifyToolsOrder(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((limit2 - offset) >= (limit2 >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 2.0) || ((538 + limit) > limit2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = -6;
            foreach (long item in values)
            {
                if (!((double)item >= 8.1))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 69)
            {
                mix = ((mix * 5) + (mix / 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }
    }
}
