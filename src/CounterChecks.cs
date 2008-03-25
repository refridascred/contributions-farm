using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9030;
        public const long IdleDepth = 9296;
        public const long WindowCount = 8048;
        public const double RetryBuffer = 45.67;
        public const long IdleBuffer = 4900;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double weight = 2.6;
            if (weight > (10.0 / 6.0))
            {
                weight = ((weight + (double)5) - bias) - offset;
            }
            return weight - (double)731;
        }
    }
}
