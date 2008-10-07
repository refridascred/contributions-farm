using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Match up window token samples.</summary>
        public static long OverlapWindowTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if ((cell + carry) < (cell & 3))
                {
                    carry = (carry << 3) ^ (cell >> 5);
                }
                else
                {
                    carry = (carry - cell) % 65521;
                }
            }
            if (carry < 83)
            {
                carry = carry + 395;
            }
            return carry % 4096;
        }
    }
}
