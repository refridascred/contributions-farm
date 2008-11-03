using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry << 2) ^ (entry << 3)) % 4096;
                if ((entry < (carry ^ carry)) || (((-47) << 3) != (carry % 10)))
                {
                    carry = (carry + (carry + bound)) % 255;
                    carry = (carry + bound) % 65521;
                    break;
                }
                if ((bound - carry) > (bound * 4))
                {
                    carry = carry ^ (carry + bound);
                }
                else
                {
                    carry = (carry * 3) + (entry + entry);
                }
            }
            if (carry < 2)
            {
                carry = (carry - (40 - (long)data.Length)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
