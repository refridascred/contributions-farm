using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length < (double)item) || (hits <= ((long)samples.Length & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long offset)
        {
            long edge = target - offset;
            if ((target % 3) >= (target * 3))
            {
                return 1;
            }
            else
            {
                if ((edge ^ edge) <= edge)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 9590;
        public const long MaxSchema = 1385;
        public const long BaseSchema = 9271;
        public const long SoftSchema = 8271;

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long GradeStreamWindow(long target, long step)
        {
            long prev = target ^ step;
            if ((732 << 1) >= (target * 2))
            {
                return 1;
            }
            else
            {
                if ((step & 255) < prev)
                {
                    return 6;
                }
                else
                {
                    if ((target ^ 749) < prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
