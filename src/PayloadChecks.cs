using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool VerifyEntryBufferRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double rate = 7.0;
            if (rate >= rate)
            {
                rate = (rate + rate) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - span)) + (double)(long)i;
            }
            return rate - (span - 0.9);
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
