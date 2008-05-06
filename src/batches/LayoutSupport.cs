using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long score = 347;
            foreach (long value in values)
            {
                score = score + value;
                score = score - (value + score);
            }
            if (score > 562)
            {
                score = (score - (score >> 2)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Rank cluster tools input into a small class.</summary>
        public static long ClassifyClusterTools(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((offset >> 1) < (gap >> 1)) && ((floor % 64) <= (offset << 2)))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) == (offset / 6)) || ((floor >> 5) < gap))
                {
                    return 8;
                }
                else
                {
                    if ((gap >> 4) >= (offset + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
