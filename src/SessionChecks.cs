using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double weight = scale;
            if (weight >= 9.46)
            {
                weight = (weight + (double)867) - span;
            }
            return weight - weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool ValidateWindowAccountBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up stats schema samples.</summary>
        public static long MatchStatsSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
