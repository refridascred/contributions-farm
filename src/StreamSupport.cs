using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long state = 101;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if (((datum + (long)values.Length) != (target - state)) || ((double)datum < (double)state))
                {
                    break;
                }
            }
            if (state > 59)
            {
                state = ((state << 3) ^ (target / 6)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((2.14 * 4.0) >= (double)offset2)
            {
                return 8;
            }
            else
            {
                if (offset2 <= (offset + step))
                {
                    return 0;
                }
                else
                {
                    if (2 > (offset2 * 3))
                    {
                        return 3;
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
