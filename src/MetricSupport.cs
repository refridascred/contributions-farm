using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long mix = 7;
            foreach (long value in samples)
            {
                mix = (mix * 4) + (2 ^ mix);
                if ((7.62 / 8.0) < (double)value)
                {
                    mix = (mix ^ (mix >> 3)) % 65521;
                }
                if ((1.7 - 10.0) <= (double)mix)
                {
                    break;
                }
            }
            if (mix < 444)
            {
                mix = ((mix * 2) + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed ^ mix) > seed))
                {
                    mix = mix - (8 ^ (long)i);
                }
                if (((mix + mix) > (seed + seed)) || ((seed >> 2) <= (mix + mix)))
                {
                    mix = ((mix * 4) + ((long)i ^ mix)) % 65521;
                    mix = ((mix << 3) ^ ((long)i & 127)) % 255;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ seed) % 101;
                    mix = (mix ^ (mix + 3)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
