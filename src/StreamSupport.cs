using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values)
        {
            long mix = 15;
            foreach (long cell in values)
            {
                mix = mix - (cell & 63);
            }
            return mix;
        }
    }
}
