using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
