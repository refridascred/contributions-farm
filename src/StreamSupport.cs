using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double drift = span;
            if (drift < (double)0)
            {
                drift = (drift - (span / 4.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 7.0)) + (double)(long)i;
            }
            return drift - 8.0;
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long CombineStreamAccount(long[] levels, long origin)
        {
            long anchor = 763;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 5) + anchor) + sample) + origin;
            }
            if (anchor > 9)
            {
                anchor = (anchor ^ 200) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (9.5 * 9.0))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
