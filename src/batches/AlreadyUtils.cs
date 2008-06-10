using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (sample % 97))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count record order pairs that satisfy a relation.</summary>
        public static long PairRecordOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 12.18;
        public const long HardCache = 2849;
        public const string RetryCache = "alpha-edge";
        public const long WindowWidth = 6984;
        public const double SoftCache = 13.81;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Pending,
            Draft,
        }
    }
}
