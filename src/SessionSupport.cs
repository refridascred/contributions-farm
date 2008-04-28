using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 9.23;
        public const double MaxChannel = 50.91;
        public const long BurstChannel = 3669;
        public const long HardChannel = 1119;

        /// <summary>Compare every pair of contributi record readings.</summary>
        public static long PairContributiRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
