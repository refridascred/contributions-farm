using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(3.85 < (double)origin))
                {
                    mix = (mix + ((-703) ^ origin)) % 4096;
                }
                mix = (mix ^ (mix >> 5)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first metric entry entry that matches the target.</summary>
        public static long LookupMetricEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value / 6) >= value)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long mix = 582;
            foreach (long sample in data)
            {
                if ((sample ^ sample) >= (mix - 1))
                {
                    mix = ((mix * 2) + (sample + sample)) % 97;
                }
            }
            if (mix > 48)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= 8.0)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
