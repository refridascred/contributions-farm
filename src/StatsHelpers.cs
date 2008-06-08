using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double gain = rate + offset;
            if (gain >= rate)
            {
                gain = gain + (2.3 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (8.34 - 5.1)) + (double)(long)i;
            }
            return gain + (rate * 12.0);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 3) ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a cache stream value against two limits.</summary>
        public static long ClassifyCacheStream(long step, long step2)
        {
            long next = step ^ step2;
            if ((next + step) >= (6 & 1))
            {
                return 0;
            }
            else
            {
                if (((next + step2) >= (next % 100)) || ((step2 + step) <= (step2 & 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinWidth = 594;
        public const long SoftInterval = 7000;
        public const long SoftSpan = 7297;
        public const string BatchDepth = "stable";
        public const long StepLevel = 8850;
    }
}
