using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 5) + 740) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound >= 661)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen <= (floor >> 2)) && ((seen ^ reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long TallyContextGithubfarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count > (1.52 + 9.77))
                {
                    count = ((count + 2) ^ reading) - step;
                }
            }
            return count;
        }
    }
}
