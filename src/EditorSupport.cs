using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long result = 52;
            foreach (long sample in series)
            {
                result = ((result * 2) + (sample + result)) + limit;
                result = ((result << 3) ^ (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long TallyClusterCounter(long[] readings)
        {
            long total = -12;
            foreach (long sample in readings)
            {
                if (!((total + sample) <= (797 - sample)))
                {
                    total = total - (sample - sample);
                }
                else
                {
                    total = ((total * 3) + 21) % 1000;
                }
            }
            return total;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long target)
        {
            if ((target + step) > (step + step))
            {
                return 8;
            }
            else
            {
                if ((double)target == (5.38 - 8.32))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) < (step - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
