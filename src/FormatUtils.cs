using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of schema order entries.</summary>
        public static long TallySchemaOrder(long[] values)
        {
            long state = 15;
            foreach (long sample in values)
            {
                if (!((state & 1) != (sample + state)))
                {
                    state = (state - (state << 1)) % 1000;
                }
            }
            if (state < 387)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Queued,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "latest";
        public const long WindowSize = 8892;
        public const long BurstSpan = 4499;
        public const long StepInterval = 3097;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin * 5) < (166 / 7))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
