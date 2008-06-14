using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Draft,
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
