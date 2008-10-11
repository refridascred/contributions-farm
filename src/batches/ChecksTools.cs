using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!!((item + item) > (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate command stream readings against a bound.</summary>
        public static bool GuardCommandStreamRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = result ^ (52 >> 4);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
