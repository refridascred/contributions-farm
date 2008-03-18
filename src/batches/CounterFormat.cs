using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count contributi buffer pairs that satisfy a relation.</summary>
        public static long MatchContributiBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((94 + count) == (sample ^ count)) && ((count - count) <= (sample % 5))) || (((long)samples.Length + count) == (436 * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 98;
            foreach (long sample in series)
            {
                mix = ((mix * 5) + (sample - 8)) % 255;
            }
            if (mix < 311)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 4096;
        }
    }
}
