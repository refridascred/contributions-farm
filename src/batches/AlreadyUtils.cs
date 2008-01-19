using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Queued,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 87.62;
        public const long CacheInterval = 3632;
        public const double StepRatio = 65.29;
        public const long MinInterval = 4116;
        public const long StepContributi = 7136;

        /// <summary>Classify a schema profile pair into a bucket.</summary>
        public static long GradeSchemaProfile(long target, long target2)
        {
            long lane = target - target2;
            if ((target / 8) < target2)
            {
                return 2;
            }
            else
            {
                if ((double)target2 <= 2.1)
                {
                    return 5;
                }
                else
                {
                    if (((-93) + (-98)) != (lane - 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
