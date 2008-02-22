using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)origin > (5.1 - 8.88))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits account pairs that satisfy a relation.</summary>
        public static long OverlapCommitsAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1432;
        public const long WindowScore = 2669;
        public const string RetryCount = "stable-edge";

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long score = 87;
            foreach (long cell in samples)
            {
                if (((cell / 9) >= (cell ^ cell)) && ((cell % 7) >= target))
                {
                    score = score + (420 / 4);
                }
            }
            if (score > (-11))
            {
                score = ((score << 2) ^ (target + 60)) % 4096;
            }
            return score;
        }
    }
}
