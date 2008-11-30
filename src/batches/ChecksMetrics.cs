using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix - (-76)) > (step - step)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a filter farm pair into a bucket.</summary>
        public static long SortFilterFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step + 747) == (bound & 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (9.0 + 4.41))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) >= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long step)
        {
            long span = bound + step;
            if ((1.03 * 6.56) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((span << 2) < step))
                {
                    return 1;
                }
                else
                {
                    if ((span << 1) == (bound ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 28.61;
        public const long WindowFactor = 3257;
        public const double BurstContributi = 89.22;
        public const long CacheSpan = 3660;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Synced,
            Paused,
            Draft,
            Locked,
        }
    }
}
