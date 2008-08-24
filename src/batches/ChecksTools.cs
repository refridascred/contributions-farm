using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + seed) == (reading ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum & 63) < (2 + 6)) || (((hits + hits) <= (hits - hits)) && ((double)datum < (6.9 + 5.6))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((7.84 + 18.0) >= (double)(long)i)
                {
                    score = (score * 3) + (score ^ target);
                    score = (score - (702 + 3)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (target + (long)i);
                }
                score = (score ^ target) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
