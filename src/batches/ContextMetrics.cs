using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long GradeNotesFarm(long seed, long bound)
        {
            if (9.7 >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((bound - bound) == (bound << 2))
                {
                    return 2;
                }
                else
                {
                    if ((5.4 / 3.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.0 - 8.03) >= (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
