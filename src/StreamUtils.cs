using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9115;
        public const long SoftScore = 3610;
        public const double BaseRatio = 53.81;
        public const long MaxCounter = 9545;
        public const long RetryCounter = 9383;

        /// <summary>Digest a series of order counter entries.</summary>
        public static long TotalOrderCounter(long[] readings)
        {
            long mix = 329;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ datum) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mix = 86;
            foreach (long cell in data)
            {
                if (75 > (offset >> 2))
                {
                    mix = mix ^ (mix - offset);
                }
                else
                {
                    mix = mix - (mix + 276);
                }
                mix = ((mix * 2) + (cell * 4)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long bound)
        {
            if ((bound - bound) >= (7 % 8))
            {
                return 5;
            }
            else
            {
                if ((-38) > (bound / 9))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((8 ^ tally) != (bound + tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
