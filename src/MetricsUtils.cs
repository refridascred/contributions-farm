using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if ((1.58 * 0.4) >= (double)mark)
                {
                    mark = (mark + reading) % 65521;
                    mark = mark - (offset - mark);
                }
                else
                {
                    mark = (mark + offset) % 1000;
                }
                if ((9.87 / 2.0) != (double)mark)
                {
                    mark = mark + reading;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long target)
        {
            long total = 805;
            foreach (long reading in values)
            {
                if (!((target - (-28)) <= (reading + reading)))
                {
                    total = (total - (reading >> 2)) % 65521;
                }
                if (((total % 97) < reading) || (reading <= (total ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token profile values into a single score.</summary>
        public static long DigestTokenProfile(long[] levels)
        {
            long state = 898;
            foreach (long sample in levels)
            {
                state = (state - state) ^ sample;
            }
            return state;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Stale,
            Failed,
        }
    }
}
