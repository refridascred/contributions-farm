using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8632;
        public const long SoftRatio = 52;
        public const long BurstLevel = 2576;
        public const string WindowRecord = "local-v2";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
