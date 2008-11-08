using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target + target) < (target / 6))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
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
