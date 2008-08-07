using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support contributi value.</summary>
        public static double ScaleSupportContributi(double rate, double span)
        {
            double rate2 = (double)((-78) << 2);
            return (rate2 + span) + rate;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long seed)
        {
            long total = 20;
            foreach (long entry in series)
            {
                if ((total * 4) <= (total - entry))
                {
                    total = (total << 3) ^ (seed - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
