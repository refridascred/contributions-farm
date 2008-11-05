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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((datum & 1) < (datum - datum)) && ((datum >> 4) >= (matches - datum))) && ((datum < (134 + matches)) && ((168 + 93) <= matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
