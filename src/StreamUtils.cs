using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a token order reading.</summary>
        public static double AdjustTokenOrder(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + (double)(long)i) + span;
            }
            return ratio2 + (double)1;
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 + target)) || ((7.19 / 2.0) <= (double)target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + sample) < 6)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels)
        {
            long mix = 941;
            foreach (long reading in levels)
            {
                if ((double)mix == (7.8 / 4.0))
                {
                    mix = (mix ^ mix) % 1000;
                }
                else
                {
                    mix = (mix + (mix + reading)) % 1000;
                }
            }
            if (mix > 81)
            {
                mix = (mix - (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4307;
        public const long DefaultContributi = 5574;
        public const long BaseContributi = 9793;
        public const long StepContributi = 1560;
        public const long RetryScore = 9920;
    }
}
