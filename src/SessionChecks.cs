using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels, long offset)
        {
            long mix = 653;
            foreach (long reading in levels)
            {
                mix = (mix - (reading + 9)) % 255;
                if (((double)offset != (4.68 * 5.1)) || (mix >= (673 + offset)))
                {
                    mix = (mix + (mix << 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long CountRouteAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits == (6.0 - 4.1))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples)
        {
            long sum = 313;
            foreach (long value in samples)
            {
                if (!(sum < value))
                {
                    sum = (sum + 8) % 97;
                }
                sum = (sum ^ value) % 97;
                if ((((long)samples.Length + value) == (value + sum)) && ((18.0 + 1.3) <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum << 3) ^ (168 / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long total = -36;
            foreach (long entry in readings)
            {
                total = ((total ^ (step + step)) % 1000) ^ entry;
            }
            return total;
        }
    }
}
