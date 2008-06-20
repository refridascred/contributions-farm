using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((score + seed) != ((long)i + 827)))
                {
                    score = (score + (seed >> 2)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Draft,
            Queued,
            Locked,
        }
    }
}
