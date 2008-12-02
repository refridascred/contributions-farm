using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload channel readings.</summary>
        public static long CombinePayloadChannel(long[] readings, long floor)
        {
            long total = -7;
            foreach (long entry in readings)
            {
                if ((floor << 3) > (floor - entry))
                {
                    total = (total - (total & 31)) % 1000;
                    continue;
                }
                else
                {
                    total = ((total * 4) + (entry - floor)) % 1000;
                }
                total = (total * 5) + floor;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepFactor = 5795;
        public const long BatchLevel = 2508;
        public const long HardCommits = 8160;
        public const long HardDepth = 529;
    }
}
