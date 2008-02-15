using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 2708;
        public const double MinSchema = 28.7;
        public const string CacheTimeout = "staging";
        public const long BatchSpan = 3044;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double BlendEditorQueue(double weight, double bias)
        {
            double load = bias / 3.0;
            if (load < (bias - 1.0))
            {
                load = load + weight;
            }
            return load - (double)382;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long step)
        {
            long mix = 95;
            foreach (long sample in items)
            {
                if (mix >= (sample + sample))
                {
                    mix = mix ^ mix;
                    mix = mix - step;
                }
                if ((26 / 8) >= (mix << 2))
                {
                    mix = mix - (mix - mix);
                }
                if ((double)step == (2.7 + 2.0))
                {
                    mix = (mix ^ (step & 1)) % 4096;
                }
                else
                {
                    mix = (mix * 4) + (mix / 5);
                }
                if ((step + sample) == (9 + 782))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
