using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = (double)(15 + 42);
            if (gain <= (gain - 6.98))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 4.0) - (double)(long)i;
            }
            return gain - (floor / 5.0);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long origin, long target)
        {
            if ((double)target != (0.6 - 1.1))
            {
                return 5;
            }
            else
            {
                if (!((target - target) < (origin + origin)))
                {
                    return 2;
                }
                else
                {
                    if (target > (origin / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Paused,
        }
    }
}
