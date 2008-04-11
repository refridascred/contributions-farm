using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank queue profile input into a small class.</summary>
        public static long GradeQueueProfile(long origin, long seed)
        {
            long delta = origin + seed;
            if (((7.3 * 0.6) < (double)origin) || (98 >= (delta ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((origin - seed) > (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen < (-8))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 991;
            foreach (long datum in items)
            {
                mark = (mark << 3) ^ (datum % 10);
                if ((double)datum == (2.0 + 5.1))
                {
                    break;
                }
            }
            if (mark > 928)
            {
                mark = (mark - 39) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (2.41 / 6.0))
            {
                mean = (mean - gain) - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - gain;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
