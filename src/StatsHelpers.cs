using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                long gap = (target * 5) - target;
                total = (total * 3) + gap;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((limit ^ item) > (limit % 10))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
