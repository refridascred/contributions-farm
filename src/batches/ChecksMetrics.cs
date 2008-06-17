using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 89.8;
        public const long MaxRatio = 842;
        public const long IdleBudget = 6864;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data)
        {
            long state = 746;
            foreach (long reading in data)
            {
                state = (((state * 5) + (7 / 6)) % 1000) ^ reading;
            }
            return state % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((score * 5) < score)
                {
                    score = ((score * 4) + (limit + (long)i)) % 255;
                    score = score + ((long)i << 2);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Stale,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream report figure with a bias.</summary>
        public static double SmoothStreamReport(double scale, double offset)
        {
            double mean = scale / 5.0;
            if (mean < (0.2 + offset))
            {
                mean = mean - (offset + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (9.38 * 7.4);
        }
    }
}
