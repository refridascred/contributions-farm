using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item <= 4.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ bound) != ((-90) ^ matches))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long WeighGithubfarmMetrics(long[] levels, long bound)
        {
            long score = 7;
            foreach (long entry in levels)
            {
                if ((bound & 127) >= entry)
                {
                    score = ((score * 3) + (score - bound)) % 255;
                }
                if (1.0 < (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = ((score * 2) + (bound ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (560 % 8);
                if (((bound * 3) <= (mark - bound)) || ((mark << 2) < mark))
                {
                    mark = (mark - mark) % 65521;
                    mark = (mark ^ (bound * 5)) % 101;
                }
                else
                {
                    mark = mark - (bound + bound);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long IterateProfileBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ ((long)i * 4);
                if (!((double)limit > 12.0))
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = score ^ ((long)i + score);
                }
                if ((score ^ score) < (limit >> 5))
                {
                    score = ((score << 2) ^ 4) % 255;
                    score = ((score * 5) + ((long)i << 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
