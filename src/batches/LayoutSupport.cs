using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count route editor pairs that satisfy a relation.</summary>
        public static long PairRouteEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 3) ^ ((long)i ^ total)) % 101) - (long)i2;
                }
                total = ((total << 3) ^ (86 + bound)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long AuditGraphChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 15) >= (seen / 2))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
