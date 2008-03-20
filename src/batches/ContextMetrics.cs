using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Queued,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Rank already cache input into a small class.</summary>
        public static long GradeAlreadyCache(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff << 2) < diff)
            {
                return 1;
            }
            else
            {
                if ((diff + 6) != (origin & 7))
                {
                    return 3;
                }
                else
                {
                    if (71 > (bound & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((diff ^ origin) >= 75) || ((bound + origin) > diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((8 / 3) == (item / 9))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long BucketContributiMetrics(long step, long step2)
        {
            if ((3.13 * 6.0) == (double)step)
            {
                return 3;
            }
            else
            {
                if ((59 * 5) >= (step ^ step2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
