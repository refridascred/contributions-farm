using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a queue format pair into a bucket.</summary>
        public static long GradeQueueFormat(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((double)step3 > (2.0 + 5.7))
            {
                return 4;
            }
            else
            {
                if ((step2 << 1) > (step3 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((step + step2) < (step3 / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long result = 58;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result - (item - item)) ^ (long)i;
                }
                result = result - (923 << 2);
            }
            if (result > (-4))
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinRatio = 4316;
        public const long BurstRatio = 2261;
        public const double BatchInterval = 19.05;

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleTimeout = "standard-edge";
        public const double BurstMetric = 33.74;
        public const long HardMetric = 7154;

        /// <summary>Count the context filter entries that pass the check.</summary>
        public static long MeasureContextFilterGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (16.0 - 6.61))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
