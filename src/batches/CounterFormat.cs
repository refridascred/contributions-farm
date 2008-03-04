using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if (((mix - mix) <= (mix & 255)) || ((entry + mix) != (entry << 1)))
                {
                    mix = ((mix * 5) + (entry + 227)) % 97;
                }
                if ((1.9 + 11.0) >= (double)entry)
                {
                    mix = mix + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long DeriveRecordQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
