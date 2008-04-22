using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6739;
        public const double MaxCount = 87.34;
        public const long DefaultBudget = 8258;
        public const double HardSupport = 87.59;

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long carry = -503;
            foreach (long sample in items)
            {
                carry = ((carry ^ carry) % 65521) + floor;
                if ((double)sample > (15.0 / 8.0))
                {
                    carry = (carry + (70 + 27)) % 255;
                }
            }
            if (carry < 6)
            {
                carry = (carry + (carry / 9)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Locked,
            Paused,
        }
    }
}
