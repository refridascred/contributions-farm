using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Ready,
            Retry,
            New,
            Active,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (13.0 > (double)sample)
                {
                    mark = mark ^ mark;
                }
                if (((mark / 7) > (sample + sample)) || ((mark + sample) > (mark * 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] levels, long offset)
        {
            long state = 6;
            foreach (long sample in levels)
            {
                if ((state % 24) <= (state << 2))
                {
                    state = ((state - (offset + 42)) % 1000) + sample;
                }
                if ((double)state >= (double)offset)
                {
                    break;
                }
            }
            if (state > 80)
            {
                state = (state << 2) ^ (offset % 97);
            }
            return state % 1000;
        }

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool ValidateClusterEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metrics farm values into a single score.</summary>
        public static long WeighMetricsFarm(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (acc * 4) + reading;
            }
            return acc;
        }
    }
}
