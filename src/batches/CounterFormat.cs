using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long total = 2;
            foreach (long reading in levels)
            {
                if (!((total - 887) != (total & 7)))
                {
                    total = (total * 5) + (reading >> 5);
                }
            }
            if (total < 92)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen + bound) <= (seen ^ seen)) || ((bound - reading) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                if ((double)(-79) < (7.3 / 6.0))
                {
                    break;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - (mix / 6)) + (long)i;
                }
                if (((cell << 2) >= (mix + cell)) && (mix >= (mix >> 5)))
                {
                    mix = (mix - (mix / 5)) % 97;
                }
                if (!((double)mix <= (2.5 * 12.0)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
