using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up buffer metrics samples.</summary>
        public static long MatchBufferMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
