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

        /// <summary>Locate a record report reading by value.</summary>
        public static long FindRecordReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Queued,
            Failed,
            Idle,
            Ready,
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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long acc = 293;
            foreach (long datum in data)
            {
                acc = (acc + (datum + 3)) % 1000;
            }
            return acc % 97;
        }
    }
}
