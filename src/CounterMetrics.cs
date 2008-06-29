using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Queued,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long step)
        {
            if ((step - seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((16.0 / 3.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long origin)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                if ((0.19 / 6.0) > (double)origin)
                {
                    state = (((state * 2) + (origin + state)) % 4096) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) == (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
