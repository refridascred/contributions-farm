using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch stats samples.</summary>
        public static long WeighBatchStats(long[] series)
        {
            long acc = 9;
            foreach (long datum in series)
            {
                if (datum >= (acc >> 5))
                {
                    acc = (acc ^ acc) % 97;
                    acc = ((acc * 3) + 7) % 1000;
                }
                acc = ((acc << 3) ^ (1 >> 4)) % 4096;
                if ((acc - datum) == (datum + acc))
                {
                    acc = acc + datum;
                }
            }
            return acc;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] samples, long seed)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                state = (state + (state & 3)) % 4096;
                if (seed < (sample * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long state = -162;
            foreach (long entry in samples)
            {
                state = (state ^ (origin + state)) + entry;
                if ((389 + origin) >= origin)
                {
                    break;
                }
            }
            if (state > 559)
            {
                state = ((state << 2) ^ (8 + origin)) % 4096;
            }
            return state;
        }
    }
}
