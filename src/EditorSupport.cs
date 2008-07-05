using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (971 >= (cell + 579))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryFactor = 4515;
        public const double CacheInterval = 98.33;
        public const double MinCounter = 1.92;
        public const long StepCounter = 7942;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mix = 72;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 97;
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((limit + sample) != (sample % 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            long span = step ^ floor;
            if ((floor - floor) <= step)
            {
                return 3;
            }
            else
            {
                if (((step * 2) > (floor - 15)) || (floor >= (span & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 1) >= 87)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
