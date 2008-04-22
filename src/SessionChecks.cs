using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate > (rate / 2.0))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor / 8.0)) - (double)(long)i;
            }
            return rate + 9.51;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
