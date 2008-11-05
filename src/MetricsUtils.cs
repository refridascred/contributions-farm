using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long FoldBatchesCounter(long[] items)
        {
            long anchor = 975;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor >> 2)) - sample;
            }
            return anchor;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long step)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if (!((double)carry == (8.1 * 7.0)))
                {
                    carry = ((carry - reading) % 1000) + step;
                }
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((8.96 + 7.53) < (9.03 - 11.0))
                {
                    mix = ((mix << 2) ^ (reading ^ mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ ((long)i % 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
