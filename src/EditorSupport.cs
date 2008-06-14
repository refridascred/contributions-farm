using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] series, long step)
        {
            long carry = 92;
            foreach (long cell in series)
            {
                if (!((double)cell <= (9.1 - 20.0)))
                {
                    carry = (carry - (step - (-1))) % 65521;
                }
                else
                {
                    carry = (carry + (carry + cell)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double rate = (floor * 6.17) / 4.0;
            if (rate >= 17.0)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate - scale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long acc = 559;
            foreach (long item in series)
            {
                if ((double)item >= 6.3)
                {
                    acc = (acc - (target % 64)) % 1000;
                }
            }
            return acc;
        }
    }
}
