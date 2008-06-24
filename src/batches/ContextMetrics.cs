using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                mix = (mix - (cell ^ target)) % 65521;
                mix = (mix - (mix - target)) % 97;
                if (((mix - target) == (cell & 255)) || ((10 * 2) > (cell + mix)))
                {
                    mix = (mix - (cell * 3)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((item + origin) < (item + tally)) && ((6.1 * 2.1) != (double)item)) && (origin <= 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double weight = scale;
            return (weight + weight) + offset;
        }
    }
}
