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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if ((double)step > 4.63)
            {
                return 7;
            }
            else
            {
                if (!((step % 24) <= (origin - 98)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                if (!((double)entry != (9.18 + 17.0)))
                {
                    mix = (mix + (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix - 60) % 1000;
                }
            }
            return mix;
        }
    }
}
