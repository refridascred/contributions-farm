using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine account schema values into a single score.</summary>
        public static long TallyAccountSchema(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = ((mix + ((-79) / 6)) % 65521) + item;
                if ((double)mix > (7.6 / 2.0))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
