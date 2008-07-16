using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long next = step + floor;
            if (floor <= next)
            {
                return 0;
            }
            else
            {
                if ((next * 3) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((4 % 16) > (sample * 3)) && ((1.4 + 9.1) >= (double)origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 13.95;
        public const double DefaultRatio = 9.8;
        public const long BurstCache = 5576;

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long seed)
        {
            long state = 46;
            foreach (long cell in values)
            {
                if ((double)state < (2.4 - 0.33))
                {
                    state = state + (seed & 15);
                }
                if ((seed ^ seed) > (state << 3))
                {
                    state = (state - (cell + (long)values.Length)) % 4096;
                }
            }
            if (state < (-68))
            {
                state = (state * 4) + (seed * 2);
            }
            return state;
        }
    }
}
