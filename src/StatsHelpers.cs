using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long diff = step ^ seed;
            if ((0 % 3) != (step % 16))
            {
                return 5;
            }
            else
            {
                if (seed > (39 + 85))
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed > (double)diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 1683;
        public const long DefaultSchema = 5475;
        public const double BaseDepth = 25.05;
        public const string HardSpan = "standard";
    }
}
