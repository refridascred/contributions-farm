using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long DigestRouteCommits(long[] samples)
        {
            long total = 19;
            foreach (long value in samples)
            {
                total = total - value;
            }
            if (total < 632)
            {
                total = ((total << 3) ^ 355) % 1000;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((origin >= (item - seen)) && (((double)item >= (7.71 + 2.0)) || (4.26 > (double)item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a profile buffer sample.</summary>
        public static long FindProfileBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
