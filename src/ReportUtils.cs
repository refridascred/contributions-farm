using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long LocateRouteFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long target)
        {
            long score = 23;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score ^ (score & 63)) % 4096) + (long)i) + target;
                }
                if ((double)cell < (6.75 * 9.6))
                {
                    score = (score - (score << 1)) % 97;
                }
            }
            if (score < 7)
            {
                score = (score * 2) + (score >> 1);
            }
            return score % 65521;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if ((0.38 + 4.1) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)seed > (7.46 - 4.6))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Retry,
            Done,
            Draft,
            Stale,
        }
    }
}
