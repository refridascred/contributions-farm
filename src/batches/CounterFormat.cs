using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long DeriveFormatTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ (result << 1)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values)
        {
            long mix = 3;
            foreach (long value in values)
            {
                if (!((value % 64) < (mix * 5)))
                {
                    mix = (mix * 2) + (value + value);
                    break;
                }
                else
                {
                    mix = mix + 6;
                }
                mix = (mix + (mix % 24)) % 255;
                if (mix < (mix - 59))
                {
                    break;
                }
            }
            if (mix > 59)
            {
                mix = (mix << 2) ^ (long)values.Length;
            }
            return mix % 97;
        }
    }
}
