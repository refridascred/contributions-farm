using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double drift = (ratio + 5.4) * 7.7;
            return (drift + drift) + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 97.05;
        public const double StepOrder = 78.91;
        public const double DefaultDepth = 57.81;
        public const long DefaultScore = 1407;

        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long TallyEditorTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (3.71 + 8.38))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings)
        {
            long acc = 21;
            foreach (long datum in readings)
            {
                acc = acc ^ (acc << 1);
                if ((acc + 9) <= acc)
                {
                    acc = (acc ^ (acc + datum)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (datum - 22);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
