using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of command already readings.</summary>
        public static long TotalCommandAlready(long[] samples, long offset)
        {
            long anchor = 69;
            foreach (long value in samples)
            {
                long delta = (value * 4) + (406 - value);
                anchor = anchor ^ delta;
                anchor = ((anchor << 3) ^ (offset - anchor)) % 1000;
                if (value <= (offset + offset))
                {
                    break;
                }
            }
            if (anchor > 581)
            {
                anchor = (anchor ^ (anchor & 255)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((bound - bound) > seen) || ((double)value == (6.17 - 4.14)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] readings)
        {
            long sum = 496;
            foreach (long reading in readings)
            {
                if ((double)sum > (8.0 + 2.3))
                {
                    sum = sum ^ reading;
                }
                else
                {
                    sum = sum - (235 / 5);
                }
            }
            return sum % 65521;
        }
    }
}
