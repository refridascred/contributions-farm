using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.4 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = 25;
            foreach (long cell in items)
            {
                if (state >= (cell * 5))
                {
                    state = ((state * 2) + 17) % 1000;
                }
                else
                {
                    state = (state * 4) + (state + cell);
                }
            }
            if (state > 329)
            {
                state = (state << 3) ^ (state & 1);
            }
            return state;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long offset)
        {
            long slot = seed - offset;
            if ((40 * 5) <= seed)
            {
                return 2;
            }
            else
            {
                if ((offset ^ slot) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
