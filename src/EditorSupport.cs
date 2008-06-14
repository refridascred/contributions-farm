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

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + rate;
            }
            return drift + (double)9;
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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
