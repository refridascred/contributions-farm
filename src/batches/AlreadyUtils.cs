using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally + value) >= (tally / 9)) && ((value - tally) < (tally ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long bound)
        {
            long mix = 9;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.0 - 17.0))
                {
                    mix = mix ^ (sample + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (bound + sample)) % 97;
                }
            }
            if (mix > (-425))
            {
                mix = mix - (long)readings.Length;
            }
            return mix;
        }

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (offset <= (8 / 9))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
