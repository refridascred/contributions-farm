using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0 + 93) != (seen + (-8)))
                {
                    seen = ((seen + 1) ^ sample) + seed;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
