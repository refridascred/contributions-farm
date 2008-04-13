using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] samples)
        {
            long mix = 337;
            foreach (long entry in samples)
            {
                if ((mix - mix) <= (entry - mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a report profile reading by value.</summary>
        public static long SeekReportProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report buffer counter forward.</summary>
        public static long RollReportBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (result + result)) % 65521;
                if (!((1.43 * 2.7) != (double)result))
                {
                    result = (result - (result << 2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
