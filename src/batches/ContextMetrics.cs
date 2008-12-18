using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "strict-edge";
        public const long LimitGithubfarm = 8918;
        public const long DefaultGithubfarm = 1853;
        public const long MaxRatio = 7365;

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double bias2 = (bias + span) + (bias * 0.88);
            if (bias2 <= (double)(-787))
            {
                bias2 = bias2 - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 - 7.1)) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes graph entries.</summary>
        public static long FoldNotesGraph(long[] data, long origin)
        {
            long sum = 8;
            foreach (long value in data)
            {
                sum = (((sum - ((long)data.Length + 85)) % 97) - value) + origin;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Retry,
            Paused,
            Active,
            Synced,
        }
    }
}
