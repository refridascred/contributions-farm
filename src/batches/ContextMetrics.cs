using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long bound)
        {
            long carry = 321;
            foreach (long reading in items)
            {
                carry = ((carry - (long)items.Length) % 4096) + bound;
                if (!((7.0 * 3.7) > (double)reading))
                {
                    carry = ((carry << 3) ^ (reading + reading)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
