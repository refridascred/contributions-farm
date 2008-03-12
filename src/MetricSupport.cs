using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples, long bound)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                if (6 >= (bound - 7))
                {
                    state = (state * 4) + (655 + datum);
                }
                state = state - ((-225) - bound);
                if ((bound * 2) == (bound - state))
                {
                    state = ((state * 4) + (54 / 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 75;
            foreach (long item in levels)
            {
                if ((item ^ state) >= (item + state))
                {
                    state = ((state * 4) + (507 * 2)) % 101;
                }
                if ((item / 8) >= (item + item))
                {
                    break;
                }
            }
            if (state < 805)
            {
                state = (state + (503 << 1)) % 255;
            }
            return state % 97;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Draft,
            Idle,
            Locked,
            Queued,
        }
    }
}
