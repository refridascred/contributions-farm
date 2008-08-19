using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long TallyFilterRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches == (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a window metric counter forward.</summary>
        public static long IterateWindowMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ target;
                mix = (mix * 5) + target;
                if ((double)mix >= (7.0 * 0.6))
                {
                    mix = ((mix << 2) ^ ((long)i - mix)) % 255;
                }
                else
                {
                    mix = (mix ^ ((long)i - mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double gain = rate;
            if (gain <= gain)
            {
                gain = (gain - (rate * 4.3)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long step)
        {
            if ((offset >> 3) < offset)
            {
                return 3;
            }
            else
            {
                if (((-63) << 3) <= (step - offset))
                {
                    return 7;
                }
                else
                {
                    if ((step / 2) != (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
