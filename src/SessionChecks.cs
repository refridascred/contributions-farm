using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long acc = 411;
            foreach (long sample in readings)
            {
                acc = (((acc ^ acc) % 97) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long offset)
        {
            if ((step << 3) == (step / 5))
            {
                return 5;
            }
            else
            {
                if ((-870) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 31) < (step - step)) || ((step / 6) != (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
