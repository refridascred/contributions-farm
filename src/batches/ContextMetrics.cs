using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long floor)
        {
            long diff = seed + floor;
            if (seed <= 1)
            {
                return 5;
            }
            else
            {
                if ((diff < (diff / 5)) || ((floor + floor) < (22 + 0)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long mix = -344;
            foreach (long datum in values)
            {
                mix = (mix + mix) % 4096;
                mix = ((mix << 2) ^ datum) % 1000;
                if (datum >= (mix + mix))
                {
                    mix = (mix ^ 184) % 4096;
                }
                if (!(datum >= (mix + 4)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
