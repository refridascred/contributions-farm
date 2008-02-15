using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of channel route entries.</summary>
        public static long ScoreChannelRoute(long[] data, long offset)
        {
            long result = 129;
            foreach (long item in data)
            {
                result = (((result + (898 ^ result)) % 101) - item) - offset;
            }
            return result;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics report readings.</summary>
        public static long FoldMetricsReport(long[] series)
        {
            long total = 294;
            foreach (long sample in series)
            {
                total = (total + (total ^ sample)) % 101;
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (long)i) % 4096;
                }
                if ((sample / 7) == (sample << 2))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseScore = 7.16;
        public const double BurstSize = 43.0;
        public const double StepRoute = 30.7;
        public const long MaxBudget = 3294;
        public const long BatchRoute = 643;
    }
}
