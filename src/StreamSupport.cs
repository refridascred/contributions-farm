using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ state) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long CombineEditorFarm(long[] readings)
        {
            long acc = -62;
            foreach (long datum in readings)
            {
                acc = (acc * 3) + (acc / 7);
                if (1.0 > (double)datum)
                {
                    acc = (acc ^ ((long)readings.Length + acc)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double gain = 2.16;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (gain + scale)) + (double)(long)i) - offset;
            }
            return gain - scale;
        }
    }
}
