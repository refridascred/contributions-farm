using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long SeekTokenFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8803;
        public const long HardSpan = 7834;
        public const long SoftLevel = 1635;
        public const string RetrySession = "primary-1";
        public const long MinSession = 3395;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double load = gain;
            if (load > floor)
            {
                load = load + floor;
            }
            return load + gain;
        }
    }
}
