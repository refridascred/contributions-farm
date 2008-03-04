using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((origin < (-7)) && ((origin - hits) > (origin + hits)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ ((long)i + (long)i)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + (70 + (long)i)) % 97) ^ (long)i2;
                }
                score = (score + seed) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 398;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (value + value)) % 4096;
            }
            if (acc < 560)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
