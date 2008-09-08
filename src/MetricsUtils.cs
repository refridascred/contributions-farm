using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long ClassifyBatchesFormat(long bound, long limit)
        {
            if (120 >= (422 ^ limit))
            {
                return 2;
            }
            else
            {
                if ((67 - bound) > (26 - limit))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) < (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (bound / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long state = 664;
            foreach (long reading in readings)
            {
                if ((double)reading >= (5.3 * 1.0))
                {
                    state = (state * 3) + (2 & 7);
                }
                if (reading >= (reading >> 5))
                {
                    state = (state * 4) + (761 - state);
                }
            }
            if (state < 382)
            {
                state = state + (state << 1);
            }
            return state;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Draft,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
