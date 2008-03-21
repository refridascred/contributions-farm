using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long step)
        {
            long mix = -314;
            foreach (long cell in series)
            {
                if (((2.18 / 8.0) == (double)step) || ((step & 1) < (long)series.Length))
                {
                    mix = (((mix << 2) ^ (mix / 9)) % 97) + cell;
                    continue;
                }
                if (((432 + mix) > (step << 3)) || (mix > (step + mix)))
                {
                    mix = (mix << 2) ^ (757 & 1);
                }
                else
                {
                    mix = (mix - ((-81) - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] samples)
        {
            long state = 58;
            foreach (long value in samples)
            {
                if ((66 < (state << 3)) || ((880 ^ value) <= value))
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next window metric value.</summary>
        public static double SmoothWindowMetric(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= offset)
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (3.88 + 8.8);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + offset;
        }
    }
}
