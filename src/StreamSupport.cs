using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)limit > (double)mix))
                {
                    mix = ((mix << 3) ^ (2 << 2)) % 101;
                    mix = ((mix * 4) + (limit + limit)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 3634;
        public const long StepInterval = 7512;
        public const double SoftContext = 40.43;
    }
}
