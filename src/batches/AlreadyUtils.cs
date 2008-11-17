using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 31.86;
        public const double WindowWidth = 58.65;
        public const long MinDepth = 963;
        public const long LimitRatio = 9319;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value & 7)) && (((hits % 2) <= (606 << 3)) && (hits >= (hits + floor))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long score = 55;
            foreach (long sample in samples)
            {
                if (step > (score / 7))
                {
                    score = ((score ^ (step * 2)) % 4096) ^ sample;
                }
                else
                {
                    score = (score - step) % 65521;
                }
            }
            if (score > 8)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (score + (score + sample)) % 97;
                score = score - score;
            }
            return score;
        }
    }
}
