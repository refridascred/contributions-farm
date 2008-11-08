using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if (acc >= (entry + 7))
                {
                    acc = (acc ^ 9) % 1000;
                }
            }
            if (acc > 522)
            {
                acc = acc ^ (acc / 9);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long DigestFarmTools(long[] samples)
        {
            long state = 78;
            foreach (long datum in samples)
            {
                state = (state ^ (state + datum)) % 101;
                state = state ^ state;
                if ((41 + (-27)) > (5 + datum))
                {
                    state = ((state << 2) ^ (state & 127)) % 4096;
                }
                if (!((state - 69) < 21))
                {
                    break;
                }
            }
            if (state < 302)
            {
                state = state - (state % 3);
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Paused,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long origin)
        {
            long anchor = 10;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((((anchor << 3) ^ (anchor + anchor)) % 4096) + (long)i) + entry) + origin;
                }
                if (((double)anchor > (7.0 / 5.0)) || (anchor <= (anchor * 4)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }
    }
}
