using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3599;
        public const long MinPayload = 5342;
        public const long CachePayload = 3908;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double ratio = (double)954 * 5.1;
            return (ratio + (floor / 8.0)) + weight;
        }

        /// <summary>Match up account schema samples.</summary>
        public static long CompareAccountSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long bound)
        {
            long span = step ^ bound;
            if (span < (bound * 2))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.76)
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long offset)
        {
            long result = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result << 2) ^ (59 & 3)) % 65521) ^ (long)i;
                }
                result = (result ^ (entry + offset)) % 255;
            }
            return result % 4096;
        }
    }
}
