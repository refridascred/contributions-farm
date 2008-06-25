using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next window layout value.</summary>
        public static double ProjectWindowLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate <= offset)
            {
                rate = rate - (weight * 0.05);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)0;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long target)
        {
            long carry = 509;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (661 & 3)) % 1000;
                if ((target - datum) < (datum % 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 1506;
        public const long HardProfile = 7215;
        public const string BatchBudget = "open";
    }
}
