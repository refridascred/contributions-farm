using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            if ((double)bound < (2.4 * 0.52))
            {
                return 0;
            }
            else
            {
                if ((bound >> 2) < 764)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool ValidateBufferMetricRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double load = (gain - 9.1) / 3.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)197) + (double)(long)i) - bias;
            }
            return load + (double)(-9);
        }
    }
}
