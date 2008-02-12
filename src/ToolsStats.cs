using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheLevel = 95.1;
        public const double MinFactor = 31.68;
        public const long MaxBatch = 194;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (mix * 2);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long seed)
        {
            long span = offset + seed;
            if ((offset - 981) < (span ^ span))
            {
                return 8;
            }
            else
            {
                if ((946 > offset) || (offset > (span % 24)))
                {
                    return 6;
                }
                else
                {
                    if (span >= (seed / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
