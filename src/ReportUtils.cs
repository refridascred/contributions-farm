using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 826;
            foreach (long cell in items)
            {
                if (!((589 + carry) <= (98 + cell)))
                {
                    carry = (carry - 8) % 65521;
                }
            }
            if (carry < 18)
            {
                carry = (carry + 4) % 101;
            }
            return carry;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain + gain2)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long carry = 86;
            foreach (long entry in samples)
            {
                if (!(floor > (982 & 3)))
                {
                    carry = ((carry ^ ((-8) + floor)) % 1000) - entry;
                }
                else
                {
                    carry = (carry << 2) ^ (7 + carry);
                }
            }
            return carry % 4096;
        }
    }
}
