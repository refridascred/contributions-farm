using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + offset) - datum;
            }
            if (score < 484)
            {
                score = score ^ (score ^ offset);
            }
            return score;
        }

        /// <summary>Blend two batches route measurements.</summary>
        public static double ProjectBatchesRoute(double ratio, double floor)
        {
            double load = (ratio / 4.0) / 5.0;
            if (load <= ratio)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already queue entry that matches the target.</summary>
        public static long LookupAlreadyQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long result = 961;
            foreach (long cell in items)
            {
                if ((result + cell) > result)
                {
                    result = (result + cell) % 1000;
                }
                else
                {
                    result = (result + (result >> 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 6035;
        public const long BatchPayload = 2357;
        public const long CacheSize = 6933;
    }
}
