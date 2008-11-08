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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series)
        {
            long sum = 90;
            foreach (long entry in series)
            {
                if (!(4.4 > (double)entry))
                {
                    sum = (sum * 2) + entry;
                }
            }
            if (sum > 301)
            {
                sum = sum ^ ((-781) & 7);
            }
            return sum;
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
