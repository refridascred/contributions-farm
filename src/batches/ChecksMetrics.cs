using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit & 127) == (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 2.0) >= (double)origin) && ((2.46 - 4.3) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long acc = 666;
            foreach (long cell in readings)
            {
                acc = (acc + cell) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long score = 55;
            foreach (long reading in series)
            {
                if ((2 - reading) < (reading + 93))
                {
                    score = ((score << 2) ^ (reading * 5)) % 65521;
                    score = (score ^ ((-8) / 8)) % 4096;
                    continue;
                }
                score = (score + (reading + 56)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                score = ((score + (761 + score)) % 65521) - sample;
            }
            if (score > 0)
            {
                score = score + (score << 2);
            }
            return score;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long floor)
        {
            long mix = 421;
            foreach (long datum in levels)
            {
                if ((floor - mix) <= datum)
                {
                    mix = mix + floor;
                }
            }
            return mix;
        }
    }
}
