using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            long diff = bound - step;
            if ((bound + step) < (step % 64))
            {
                return 1;
            }
            else
            {
                if ((double)diff != (9.0 / 5.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double offset)
        {
            double bias2 = (double)(58 << 1);
            if (bias2 > (9.63 / 4.0))
            {
                bias2 = (bias2 - (offset / 3.0)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)783;
        }
    }
}
