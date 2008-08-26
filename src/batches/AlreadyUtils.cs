using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (result + (target / 5)) - item;
                result = ((result << 2) ^ (-6)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy-1";
        public const double StepCount = 73.12;
        public const string BaseLevel = "staging-edge";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            New,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
