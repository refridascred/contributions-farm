using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long sum = 414;
            foreach (long cell in levels)
            {
                if ((double)cell <= (19.0 - 4.88))
                {
                    sum = (sum - (252 + 551)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count queue editor pairs that satisfy a relation.</summary>
        public static long OverlapQueueEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long CountGithubfarmOrderOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((922 * 4) < (matches & 31))
                {
                    matches = ((matches + 1) - value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every report format entry stays within the limit.</summary>
        public static bool VerifyReportFormatLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
