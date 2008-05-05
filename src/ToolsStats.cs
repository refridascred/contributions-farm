using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 293;
            foreach (long reading in items)
            {
                state = ((state ^ (7 + state)) % 101) ^ reading;
            }
            if (state < 73)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double gain = (double)80 + (weight / 4.0);
            if (gain > (gain / 2.0))
            {
                gain = (gain - (double)35) + span;
            }
            return gain - 0.8;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long DigestSessionChannel(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (!((2.0 * 5.0) <= (double)score))
                {
                    score = (score + 4) + sample;
                }
            }
            return score % 4096;
        }
    }
}
