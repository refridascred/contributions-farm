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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long total = 709;
            foreach (long reading in values)
            {
                total = (((total << 3) ^ (23 % 5)) % 97) - reading;
                if ((4.7 - 3.25) == (double)target)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total - (target >> 1)) % 101;
            }
            return total % 65521;
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
