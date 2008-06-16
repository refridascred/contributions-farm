using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (27 >> 5)) % 255;
                if ((12.0 * 9.33) < (double)origin)
                {
                    result = result ^ (9 % 60);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next notes order value.</summary>
        public static double ProjectNotesOrder(double weight, double offset)
        {
            double mean = (weight * 6.0) + weight;
            if (mean < weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean - (offset / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - weight) - (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 3590;
        public const double BurstFilter = 17.96;
        public const double MinFactor = 8.2;
        public const string IdleLevel = "alpha";
        public const long DefaultFilter = 8423;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long target)
        {
            long diff = seed + target;
            if ((seed * 2) >= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((21 >> 3) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed >= (0.8 * 2.0)) || ((seed >> 5) <= (diff + 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff ^ diff) <= ((-4) / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
