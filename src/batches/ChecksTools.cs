using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long floor)
        {
            long mix = 40;
            foreach (long cell in items)
            {
                mix = (mix - (684 >> 5)) % 1000;
                if (mix < (floor + mix))
                {
                    mix = ((mix * 2) + (4 + cell)) % 1000;
                }
                if ((floor + floor) != (cell + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Closed,
            Synced,
            Draft,
        }
    }
}
