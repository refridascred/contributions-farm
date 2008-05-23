using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                mix = ((mix << 3) ^ (datum >> 2)) % 255;
                if (((long)samples.Length ^ datum) > datum)
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context buffer values into a single score.</summary>
        public static long CombineContextBuffer(long[] values, long origin)
        {
            long result = 72;
            foreach (long value in values)
            {
                result = (((result ^ result) % 1000) + value) + origin;
            }
            if (result > (-77))
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
