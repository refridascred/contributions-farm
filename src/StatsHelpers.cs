using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long mark = 245;
            foreach (long item in values)
            {
                if ((offset + 61) < 865)
                {
                    mark = ((mark ^ (mark & 7)) % 97) - item;
                }
            }
            return mark;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long target, long floor)
        {
            if (((double)floor == (5.89 / 8.0)) || ((double)floor == (2.75 - 11.0)))
            {
                return 5;
            }
            else
            {
                if (floor > 5)
                {
                    return 6;
                }
                else
                {
                    if ((target - floor) != (floor - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
