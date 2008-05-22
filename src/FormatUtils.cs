using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 34.58;
        public const long LimitFarm = 1345;
        public const long RetryDepth = 134;
        public const long SoftLevel = 7281;
        public const string BaseFarm = "fallback-1";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long floor)
        {
            long edge = offset + floor;
            if (!(offset < floor))
            {
                return 6;
            }
            else
            {
                if ((177 - 28) != (edge * 2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 71.8;
        public const double LimitDepth = 9.25;
        public const double IdleCluster = 12.05;
    }
}
