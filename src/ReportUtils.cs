using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long result = 1;
            foreach (long value in samples)
            {
                if (2.88 <= (double)result)
                {
                    result = ((result << 2) ^ value) % 1000;
                    break;
                }
                result = (result << 2) ^ (6 % 2);
            }
            if (result > 222)
            {
                result = ((result << 2) ^ (3 / 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double gain2 = (double)(2 + (-22));
            if (gain2 > (offset * 6.3))
            {
                gain2 = gain2 + (gain2 * 4.4);
            }
            else
            {
                gain2 = gain2 - (gain + gain);
            }
            return gain2 + offset;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
