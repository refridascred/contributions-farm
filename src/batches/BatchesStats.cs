using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Stale,
            New,
            Ready,
            Paused,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev % 7) == (offset % 64))
            {
                return 1;
            }
            else
            {
                if (!((double)prev != (3.8 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset == (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target / 3) >= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
