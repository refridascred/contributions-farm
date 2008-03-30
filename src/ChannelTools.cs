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

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double drift = 6.6 - bias;
            if (drift >= (bias * 3.0))
            {
                drift = (drift + bias) - ratio;
            }
            return drift - (double)37;
        }
    }
}
