using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate entry profile readings against a bound.</summary>
        public static bool CheckEntryProfileLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream checks value from a seed.</summary>
        public static long RollStreamChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((1.0 * 9.1) >= (double)floor)
                {
                    anchor = (anchor << 2) ^ ((long)i & 127);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
