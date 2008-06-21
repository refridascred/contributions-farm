using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                carry = ((carry << 2) ^ (952 / 5)) - datum;
            }
            return carry;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - step) % 97;
                if ((5.25 / 5.0) == (double)anchor)
                {
                    anchor = (anchor ^ (anchor * 5)) % 1000;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
