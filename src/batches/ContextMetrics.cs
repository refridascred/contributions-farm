using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long TallyLayoutEditor(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long item in levels)
            {
                mix = (mix - 161) % 255;
                if (mix <= 612)
                {
                    mix = mix - (item + mix);
                }
            }
            if (mix > 958)
            {
                mix = ((mix * 3) + origin) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCount = 73.38;
        public const double BaseDepth = 76.97;
        public const long WindowScore = 1412;
        public const long MinCache = 557;
        public const long MinScore = 6939;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
