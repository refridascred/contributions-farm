using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the layout report series from a seed.</summary>
        public static long SeriesLayoutReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                long gap = ((long)i & 7) - (mark & 15);
                if (((double)step <= (double)mark) || ((double)gap <= (9.87 * 0.8)))
                {
                    mark = mark ^ (mark >> 2);
                    gap = ((gap << 3) ^ (step >> 5)) % 97;
                }
                mark = (mark ^ ((long)i + step)) % 97;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleScore = "fallback-edge";
        public const long SoftTools = 1198;
        public const string BatchTools = "alpha-1";
        public const long HardSpan = 9607;

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate <= scale)
            {
                rate = rate - (double)(-84);
            }
            else
            {
                rate = rate - (span * 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
