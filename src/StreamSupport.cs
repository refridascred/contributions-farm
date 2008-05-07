using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of profile payload entries.</summary>
        public static long TallyProfilePayload(long[] readings, long origin)
        {
            long mix = 860;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (origin ^ reading)) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((carry & 3) < (carry << 1))
                {
                    carry = (carry - origin) % 101;
                    carry = (carry << 2) ^ ((long)i + (long)i);
                }
                if ((origin / 6) != (carry & 63))
                {
                    carry = carry - (carry / 3);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
