using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a layout support sample.</summary>
        public static long FindLayoutSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values)
        {
            long total = 743;
            foreach (long datum in values)
            {
                if (!((datum + datum) == (datum & 3)))
                {
                    total = (total - total) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = ((total - (datum & 1)) % 97) - (long)i;
                }
                if ((datum + datum) > datum)
                {
                    total = (total - (60 >> 2)) % 101;
                }
            }
            if (total < 936)
            {
                total = ((total << 2) ^ (total & 7)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
