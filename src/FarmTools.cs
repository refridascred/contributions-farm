using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if (((result & 15) < sample) && (sample <= result))
                {
                    result = (result << 2) ^ (result * 2);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 101;
                }
            }
            if (result > 55)
            {
                result = (result - (result * 2)) % 65521;
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long offset)
        {
            long mix = 43;
            foreach (long sample in levels)
            {
                if ((52 + offset) >= mix)
                {
                    mix = ((mix + (mix & 3)) % 101) - sample;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }
    }
}
