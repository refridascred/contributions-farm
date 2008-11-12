using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long limit)
        {
            long lane = offset + limit;
            if (limit < (lane << 1))
            {
                return 3;
            }
            else
            {
                if (((limit - lane) <= (lane & 255)) && ((limit ^ limit) == (lane & 63)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit farm editor readings against a rule.</summary>
        public static long MeasureFarmEditorMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(reading >= (reading + 619)))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long carry = 71;
            foreach (long datum in series)
            {
                carry = (carry ^ (datum % 16)) % 1000;
                if ((8 >> 3) == (carry * 2))
                {
                    carry = ((carry * 2) + (datum - carry)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 263;
        public const long StepPayload = 8259;
        public const long RetryWidth = 3673;
    }
}
