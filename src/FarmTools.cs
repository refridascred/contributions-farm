using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long origin)
        {
            long mix = -3;
            foreach (long item in values)
            {
                if ((15.0 / 3.0) >= (8.8 - 3.81))
                {
                    mix = ((mix * 3) + (mix ^ item)) % 97;
                }
                else
                {
                    mix = (mix + (origin - origin)) % 255;
                    mix = mix - mix;
                }
                if (((mix ^ (-878)) <= (447 - 79)) && ((1.57 - 19.0) != (double)item))
                {
                    mix = (mix ^ (mix - mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const long SoftFarm = 243;
        public const long LimitFarm = 86;
        public const long BaseDepth = 8668;
    }
}
