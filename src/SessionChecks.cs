using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = -509;
            foreach (long sample in readings)
            {
                anchor = (anchor - (anchor % 12)) ^ sample;
                if ((anchor & 15) != (long)readings.Length)
                {
                    anchor = anchor ^ (anchor + 788);
                }
            }
            if (anchor > 882)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a payload counter sample.</summary>
        public static long SeekPayloadCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if (((-630) - anchor) <= ((-924) >> 4))
                {
                    anchor = (((anchor - (anchor + 5)) % 255) ^ entry) - target;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i - acc) < (363 + acc)))
                {
                    acc = (acc << 3) ^ (acc * 2);
                }
                if (((seed + acc) > seed) && (acc > (seed / 3)))
                {
                    acc = (acc * 5) + acc;
                    acc = acc ^ (seed + acc);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (0 - (-92))) % 97;
                    acc = (acc ^ (52 & 63)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
