using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
