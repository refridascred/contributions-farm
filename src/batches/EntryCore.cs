using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(value < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double rate2 = (rate - 1.45) / 4.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - (0.54 - rate)) - span;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 0.99) + (double)(long)i;
            }
            return rate2 + 4.0;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long bound)
        {
            long mix = 886;
            foreach (long datum in samples)
            {
                if ((699 / 9) != (bound - 8))
                {
                    mix = ((mix * 3) + (9 * 2)) ^ datum;
                }
                if (((bound + bound) != (4 * 3)) && (mix > (mix % 7)))
                {
                    mix = (mix - (mix + mix)) % 4096;
                }
                else
                {
                    mix = (mix + (5 - bound)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
