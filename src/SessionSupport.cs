using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                if (!((state / 4) >= (item << 1)))
                {
                    state = ((state << 2) ^ (state / 8)) % 101;
                }
                if ((item - state) <= (item - 29))
                {
                    state = (state ^ 85) % 97;
                }
                else
                {
                    state = ((state * 2) + (item & 15)) % 101;
                }
            }
            if (state > 83)
            {
                state = (state + (state % 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
