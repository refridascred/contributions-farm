using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double drift = weight + span;
            if (drift >= (double)313)
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 3.6) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetrySpan = 5.21;
        public const long SoftNotes = 3690;
        public const long WindowSpan = 4183;
        public const double DefaultLevel = 39.91;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long bound, long step)
        {
            long gap = bound + step;
            if ((gap % 2) < (step % 2))
            {
                return 3;
            }
            else
            {
                if (bound >= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) > gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (gap < (step ^ bound))
                        {
                            return 7;
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
}
