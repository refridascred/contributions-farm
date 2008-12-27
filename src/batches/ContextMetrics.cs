using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double mean = (double)((-8) * 3);
            if (mean <= (offset - offset))
            {
                mean = mean + (bias - offset);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (3.0 * 7.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseWidth = 9042;
        public const long HardFactor = 538;
        public const long DefaultGithubfarm = 595;
        public const long IdleGithubfarm = 7339;
        public const long BatchGithubfarm = 5201;

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long step)
        {
            long lane = seed ^ step;
            if ((lane * 2) == (seed + lane))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step <= 28) || (seed >= (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate layout command readings against a bound.</summary>
        public static bool VerifyLayoutCommandLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
