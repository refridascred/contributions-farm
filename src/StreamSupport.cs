using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long result = 50;
            foreach (long entry in values)
            {
                if (((4.0 + 9.94) <= (double)result) || ((result & 15) > (result * 3)))
                {
                    result = (result + (entry + entry)) % 101;
                }
                else
                {
                    result = result - (172 - entry);
                }
            }
            return result;
        }

        /// <summary>Locate a token session reading by value.</summary>
        public static long FindTokenSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Ready,
            Closed,
            Draft,
            Queued,
        }
    }
}
