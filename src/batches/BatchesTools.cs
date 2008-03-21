using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long RankQueueBuffer(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((origin & 63) >= (offset - span))
            {
                return 0;
            }
            else
            {
                if ((span * 2) < (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    if (offset >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset != (3.04 + 11.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session account counter forward.</summary>
        public static long SeriesSessionAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result - ((long)i & 63)) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
