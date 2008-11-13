using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report route values into a single score.</summary>
        public static long TallyReportRoute(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = (sum ^ 3) % 97;
                if ((double)cell <= (8.5 * 12.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long SeriesGithubfarmRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate tools channel samples.</summary>
        public static long FoldToolsChannel(long[] values, long limit)
        {
            long state = 615;
            foreach (long cell in values)
            {
                state = (state + (cell - limit)) % 4096;
                if (limit <= 4)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate session schema samples.</summary>
        public static long ScoreSessionSchema(long[] series, long seed)
        {
            long result = 97;
            foreach (long item in series)
            {
                result = ((result ^ item) % 101) - seed;
            }
            if (result < 7)
            {
                result = result + (6 ^ result);
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits queue figure with a bias.</summary>
        public static double ScaleCommitsQueue(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)134)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (bias - ratio2);
            }
            return ratio2 + 13.0;
        }
    }
}
