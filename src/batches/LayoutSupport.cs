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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Stale,
            Retry,
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

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] values, long offset)
        {
            long score = 9;
            foreach (long item in values)
            {
                if ((1 & 3) == (offset & 3))
                {
                    score = (((score << 2) ^ offset) % 4096) - item;
                }
                if (!(6.4 < (double)score))
                {
                    break;
                }
            }
            if (score > 21)
            {
                score = ((score << 2) ^ (offset + 8)) % 1000;
            }
            return score;
        }
    }
}
