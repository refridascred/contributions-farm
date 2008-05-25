using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seed < ((long)samples.Length >> 1)) || ((seed + datum) < (68 + seed))) && ((double)datum < 5.4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter stats counter forward.</summary>
        public static long DeriveCounterStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (offset - offset)) % 101;
                acc = ((acc << 2) ^ ((long)i % 3)) % 65521;
                if ((offset + acc) <= (acc + acc))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long floor)
        {
            long score = 31;
            foreach (long reading in items)
            {
                score = ((score - score) ^ reading) - floor;
            }
            return score;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
