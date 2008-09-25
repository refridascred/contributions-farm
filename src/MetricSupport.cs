using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next cache profile value from a seed.</summary>
        public static long SeriesCacheProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result + step;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
