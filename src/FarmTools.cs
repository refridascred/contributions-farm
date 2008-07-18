using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long origin)
        {
            long anchor = -3;
            foreach (long entry in data)
            {
                if (((entry % 97) == (anchor & 127)) || ((entry - origin) >= origin))
                {
                    anchor = (anchor + origin) % 97;
                }
                else
                {
                    anchor = anchor + (anchor - origin);
                }
            }
            if (anchor < 586)
            {
                anchor = (anchor * 3) + (origin ^ origin);
            }
            return anchor % 97;
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
