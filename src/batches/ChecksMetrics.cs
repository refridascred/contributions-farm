using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                if ((cell ^ carry) > carry)
                {
                    carry = ((carry * 3) + 337) % 4096;
                }
                if ((cell & 15) <= cell)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit + limit) <= ((-792) % 7))
                {
                    continue;
                }
                if (!((long)i <= (limit + score)))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 905;
        public const double RetryCount = 8.97;
        public const double BurstContext = 75.44;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 7497;
        public const long BurstFactor = 2811;
        public const string WindowWidth = "open-1";
        public const string BaseDepth = "latest-v2";
        public const double DefaultToken = 57.17;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score - (sample - sample)) % 101;
            }
            return score % 65521;
        }
    }
}
