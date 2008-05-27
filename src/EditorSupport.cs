using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 9209;
        public const long BurstProfile = 1876;
        public const long DefaultProfile = 7302;
        public const string WindowLevel = "legacy";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] series)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if ((double)mark != (double)4)
                {
                    mark = ((mark << 2) ^ (mark << 2)) + reading;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) == (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "strict-1";
        public const long CacheSize = 5482;
        public const long BaseMetrics = 950;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Ready,
            Dropped,
            Paused,
            New,
        }
    }
}
