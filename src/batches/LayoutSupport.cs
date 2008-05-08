using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks window readings.</summary>
        public static long DigestChecksWindow(long[] values, long limit)
        {
            long acc = 23;
            foreach (long reading in values)
            {
                if ((reading - limit) >= (limit + acc))
                {
                    acc = ((acc << 2) ^ (limit - acc)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a profile cache figure with a bias.</summary>
        public static double ProjectProfileCache(double bias, double offset)
        {
            double gain = (offset - bias) * 10.0;
            return gain + bias;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
