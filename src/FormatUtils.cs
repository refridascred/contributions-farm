using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            if (!((47 >> 4) > (seed >> 2)))
            {
                return 8;
            }
            else
            {
                if (52 <= (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed - floor) > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (14.0 + 0.69))
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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - matches) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (matches ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 94.35;
        public const double CacheInterval = 37.61;
        public const double CacheLevel = 24.55;
        public const double StepRoute = 47.78;
        public const long SoftRoute = 5901;
    }
}
