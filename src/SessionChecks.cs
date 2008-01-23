using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long acc = 98;
            foreach (long value in series)
            {
                if (!(value <= 596))
                {
                    acc = (acc << 2) ^ (acc >> 4);
                }
                if (acc <= (seed - seed))
                {
                    acc = (acc ^ (680 ^ value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Accumulate session already samples.</summary>
        public static long DigestSessionAlready(long[] values, long seed)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell + cell)) % 65521;
                acc = (acc ^ cell) % 1000;
                if (acc <= (1 % 60))
                {
                    break;
                }
            }
            if (acc > 882)
            {
                acc = (acc + (acc + seed)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long step)
        {
            if ((bound * 3) == (step * 2))
            {
                return 2;
            }
            else
            {
                if ((bound >> 5) == (step % 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long TallyToolsAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((3.34 / 5.0) == (double)hits) && (hits >= (574 / 8)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
