using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((datum >> 4) <= (hits ^ datum)) && ((datum + hits) != (hits + hits))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
