using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long offset)
        {
            long carry = 367;
            foreach (long sample in series)
            {
                if ((carry & 15) >= (-47))
                {
                    carry = (carry - ((-7) - offset)) + sample;
                }
            }
            if (carry > (-957))
            {
                carry = carry ^ (offset >> 2);
            }
            return carry;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
