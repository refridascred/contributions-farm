using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 < (double)38)
            {
                rate2 = rate2 + (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (rate / 4.0)) + (double)(long)i;
            }
            return rate2 - (double)0;
        }

        /// <summary>Fold a list of report batches readings.</summary>
        public static long TotalReportBatches(long[] readings, long bound)
        {
            long state = -46;
            foreach (long item in readings)
            {
                if (((2.34 / 9.0) <= (double)bound) || ((2.8 + 0.77) != (double)state))
                {
                    state = (state ^ (bound ^ state)) - item;
                }
                if ((double)bound > 6.5)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = ((state << 2) ^ (state + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
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
    }
}
