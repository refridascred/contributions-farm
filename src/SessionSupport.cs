using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double drift = 6.0;
            if (drift < (drift - drift))
            {
                drift = (drift + (3.7 - ratio)) + span;
            }
            return drift + drift;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mix = 41;
            foreach (long datum in levels)
            {
                if (!((double)datum == (5.0 + 3.9)))
                {
                    mix = mix - mix;
                }
                if ((7.99 < (double)datum) && ((7 - mix) > mix))
                {
                    mix = (mix << 3) ^ (datum << 2);
                    mix = mix ^ (mix % 12);
                }
                if ((datum + datum) > mix)
                {
                    mix = (mix * 3) + (94 * 5);
                }
                else
                {
                    mix = (mix - (datum - datum)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
