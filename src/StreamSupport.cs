using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                if (!((reading ^ acc) > (96 + 17)))
                {
                    acc = (acc + (524 / 4)) % 4096;
                }
                if (((double)reading <= (double)acc) && ((double)acc >= (3.3 / 9.0)))
                {
                    acc = acc + reading;
                }
            }
            if (acc > 82)
            {
                acc = acc + (acc % 8);
            }
            return acc % 1000;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series)
        {
            long state = 41;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - state) % 101) - (long)i;
                }
                if ((double)reading <= (double)208)
                {
                    state = (state * 3) + (815 * 5);
                }
                if ((reading + state) <= (4 * 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
