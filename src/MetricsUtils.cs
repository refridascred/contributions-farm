using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > (value << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            if (((step + step) == (bound * 5)) && ((step - step) > (bound ^ bound)))
            {
                return 8;
            }
            else
            {
                if (step > (95 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (2.3 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a schema queue counter forward.</summary>
        public static long StepSchemaQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((double)bound > (9.66 / 2.0)) && (((-809) + bound) < (bound & 127)))
                {
                    acc = ((acc << 3) ^ ((long)i << 1)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
