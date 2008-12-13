using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Combine filter command values into a single score.</summary>
        public static long DigestFilterCommand(long[] values, long origin)
        {
            long result = 3;
            foreach (long reading in values)
            {
                result = result - (result ^ origin);
                if ((origin >> 4) > (reading / 4))
                {
                    result = ((result * 5) + (reading + result)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)seed < (14.0 / 9.0))
                {
                    sum = (sum - (51 / 2)) % 1000;
                    continue;
                }
                if (seed >= sum)
                {
                    sum = (sum ^ sum) % 4096;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
