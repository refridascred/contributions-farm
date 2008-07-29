using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ ((long)i % 24)) % 97;
                if (0 < (mix - (long)i))
                {
                    mix = (mix * 5) + (3 % 97);
                    mix = (mix ^ (mix / 6)) % 65521;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + step);
                    mix = (mix << 3) ^ (step + 8);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long seed)
        {
            long delta = step + seed;
            if ((7.0 - 7.21) < (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta + delta) != (29 % 5))
                {
                    return 7;
                }
                else
                {
                    if (!((step + step) <= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
