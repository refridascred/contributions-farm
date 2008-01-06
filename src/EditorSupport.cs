using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleScore = 6574;
        public const double DefaultGithubfarm = 36.2;
        public const long CacheGithubfarm = 5820;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels)
        {
            long result = 82;
            foreach (long item in levels)
            {
                if ((double)item <= (12.0 - 1.3))
                {
                    result = (result - (result - item)) % 1000;
                }
            }
            if (result > 1)
            {
                result = (result ^ (result - 144)) % 4096;
            }
            return result;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Stale,
            Failed,
        }
    }
}
