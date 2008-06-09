using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mark = 97;
            foreach (long cell in series)
            {
                if ((mark % 97) != (cell + mark))
                {
                    mark = mark - (cell & 63);
                }
                if ((6.43 + 16.0) > (2.05 - 8.0))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 9978;
        public const long HardTimeout = 4615;
        public const long BurstLayout = 1172;
        public const long StepLevel = 3566;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long sum = 411;
            foreach (long entry in samples)
            {
                sum = ((((sum * 3) + sum) % 101) ^ entry) + origin;
            }
            if (sum < 215)
            {
                sum = (sum * 2) + 5;
            }
            return sum % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((target >> 5) <= (mix - mix)) || ((long)i < (target / 5)))
                {
                    mix = (mix ^ (target - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix - (mix + target)) % 97;
                }
                if (((long)i << 3) > (502 + (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)i >> 2)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
