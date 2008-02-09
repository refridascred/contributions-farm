using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3766;
        public const string IdleAlready = "strict-v2";
        public const double RetryWidth = 30.24;
        public const long WindowAlready = 6139;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long origin)
        {
            if ((588 / 7) <= origin)
            {
                return 5;
            }
            else
            {
                if ((step ^ (-25)) <= (835 >> 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
