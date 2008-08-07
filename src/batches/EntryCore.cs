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

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "cached";
        public const long MaxTools = 1078;
        public const double LimitScore = 30.19;
        public const long SoftCount = 143;
        public const string WindowTools = "cached-edge";

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
