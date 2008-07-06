using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long step)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (51 - reading)) % 4096;
                if (((total / 4) <= (6 + step)) || ((double)reading <= (double)step))
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = ((total << 3) ^ (step - total)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long sum = 602;
            foreach (long entry in samples)
            {
                if (!(entry >= (entry + entry)))
                {
                    sum = (sum * 4) + sum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = (state << 2) ^ (state + 52);
                if ((entry + entry) <= ((long)readings.Length & 127))
                {
                    continue;
                }
                else
                {
                    state = ((state * 4) + entry) % 65521;
                    state = (state << 3) ^ (state + state);
                }
                state = (state - (entry - entry)) % 65521;
            }
            if (state > 9)
            {
                state = ((state * 4) + (state - 3)) % 97;
            }
            return state;
        }
    }
}
