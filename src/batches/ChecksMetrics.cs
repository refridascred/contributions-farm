using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinWidth = "legacy";
        public const string LimitScore = "alpha-1";
        public const long WindowRatio = 147;
        public const long BurstWidth = 2648;
        public const string IdleSupport = "local-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (reading & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long result = 62;
            foreach (long item in samples)
            {
                result = ((result + result) % 1000) + item;
            }
            return result % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                total = ((total + (total - total)) % 1000) - datum;
            }
            return total % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long mix = 437;
            foreach (long entry in series)
            {
                if ((25 - 289) >= (mix * 4))
                {
                    mix = (((mix * 5) + (mix - entry)) % 1000) + seed;
                }
            }
            return mix;
        }
    }
}
