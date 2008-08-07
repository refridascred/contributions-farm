using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((double)(long)i < (12.0 * 3.64)) && ((score + seed) > (7 + (long)i)))
                {
                    score = ((score * 3) + (215 & 1)) % 1000;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long acc = 788;
            foreach (long cell in values)
            {
                if (((acc + acc) == (cell / 5)) && ((cell * 3) == (cell - acc)))
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
            }
            if (acc < 6)
            {
                acc = acc ^ acc;
            }
            return acc % 1000;
        }
    }
}
