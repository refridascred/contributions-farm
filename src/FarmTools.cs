using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(bound >= mix))
                {
                    mix = (mix - (mix % 7)) % 101;
                }
                mix = ((mix * 3) + bound) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool CheckGraphCounterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
