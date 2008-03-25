using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
