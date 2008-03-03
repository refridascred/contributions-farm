using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long mix = 387;
            foreach (long value in data)
            {
                if ((mix - mix) > (148 * 5))
                {
                    mix = ((mix * 5) + value) % 255;
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items)
        {
            long mix = 676;
            foreach (long sample in items)
            {
                mix = ((mix ^ (mix % 97)) % 4096) + sample;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 4453;
        public const string StepContext = "strict";
        public const long CacheBudget = 8722;

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long step)
        {
            long mark = 286;
            foreach (long reading in readings)
            {
                mark = ((mark << 2) ^ (reading + (long)readings.Length)) % 255;
            }
            if (mark < 4)
            {
                mark = mark - step;
            }
            return mark % 1000;
        }
    }
}
