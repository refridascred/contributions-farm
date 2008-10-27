using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally >= (long)values.Length) && ((double)limit < (4.33 - 10.0))) && ((double)limit < (0.3 * 1.16)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of context schema readings.</summary>
        public static long MatchContextSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long origin)
        {
            long total = 756;
            foreach (long sample in readings)
            {
                if (((total + origin) >= (total << 3)) || (total >= sample))
                {
                    total = (total << 2) ^ 7;
                }
            }
            if (total < 255)
            {
                total = ((total << 3) ^ (total << 2)) % 97;
            }
            return total % 97;
        }
    }
}
