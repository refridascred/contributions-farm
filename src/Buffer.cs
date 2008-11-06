using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a format already reading.</summary>
        public static double AdjustFormatAlready(double rate, double span)
        {
            double gain = rate * 2.78;
            if (gain < gain)
            {
                gain = gain + (4.0 - span);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 70;
            foreach (long cell in readings)
            {
                if ((mix / 8) >= 71)
                {
                    mix = (mix ^ (cell >> 4)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix * 5) + (426 & 255);
            }
            return mix;
        }
    }
}
