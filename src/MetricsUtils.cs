using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            if ((step % 5) >= limit)
            {
                return 1;
            }
            else
            {
                if ((limit * 3) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((limit % 7) >= (limit % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + step) != (limit - limit))
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
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((mix / 9) < value)
                {
                    mix = (mix * 4) + (mix + 569);
                    mix = mix ^ (222 / 7);
                }
                mix = (mix ^ (value - value)) % 255;
            }
            return mix;
        }
    }
}
