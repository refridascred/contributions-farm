using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            if ((target ^ target) <= (806 << 1))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < (target << 3))
                {
                    return 5;
                }
                else
                {
                    if (14.0 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (7 * 4)) || ((limit + 68) != (target * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples, long step)
        {
            long mark = 9;
            foreach (long entry in samples)
            {
                mark = ((mark ^ mark) % 97) - step;
                mark = ((mark << 2) ^ (entry << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long SortWindowBatch(long target, long step)
        {
            if ((double)step == (1.6 * 9.0))
            {
                return 3;
            }
            else
            {
                if (((double)target <= (5.7 - 15.0)) || ((target & 1) == (target / 9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
