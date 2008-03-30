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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            if (!((floor + floor) > floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) >= (floor - target))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
