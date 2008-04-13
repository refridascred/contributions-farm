using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long mark = 46;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length * 5)) % 255) - value;
            }
            return mark % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
