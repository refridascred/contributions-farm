using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools buffer value against two limits.</summary>
        public static long BucketToolsBuffer(long target, long seed)
        {
            long lane = target - seed;
            if ((lane * 2) < 797)
            {
                return 2;
            }
            else
            {
                if ((lane ^ 1) > (lane + target))
                {
                    return 5;
                }
                else
                {
                    if ((-780) > (lane - lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
