using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((bound + 7) == (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((bound - seed) >= (313 + next))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks schema value from a seed.</summary>
        public static long StepChecksSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound % 24) < (mix / 4))
                {
                    mix = mix + ((long)i + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double gain = (double)((-71) + (-1));
            if (gain >= (1.0 - ratio))
            {
                gain = (gain + gain) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio - gain)) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Accumulate cache record samples.</summary>
        public static long FoldCacheRecord(long[] readings)
        {
            long score = 6;
            foreach (long cell in readings)
            {
                score = ((score << 2) ^ (score >> 4)) ^ cell;
                if ((score + score) <= (score - score))
                {
                    score = (score << 2) ^ (score & 15);
                }
            }
            return score % 4096;
        }
    }
}
