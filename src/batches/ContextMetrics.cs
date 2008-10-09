using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 69;
            foreach (long reading in series)
            {
                if ((seed & 3) >= (reading ^ seed))
                {
                    acc = acc + (3 + seed);
                }
                else
                {
                    acc = (acc + (seed * 5)) % 1000;
                }
            }
            if (acc < 61)
            {
                acc = ((acc << 3) ^ seed) % 255;
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell * 2) >= seen))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= (sum + target))
                {
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 4096;
                }
                if (((target - (long)i) <= (sum + target)) || (((long)i + (long)i) < target))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (target - target)) % 97;
                }
                sum = sum + 582;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
