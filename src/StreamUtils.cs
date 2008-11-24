using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a filter queue counter forward.</summary>
        public static long IterateFilterQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = (score + bound) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 2) + (offset >> 3)) % 101) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 177;
        public const double SoftScore = 86.64;
        public const string BaseSize = "standard-1";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= ((long)i << 3))
                {
                    score = score - (long)i;
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a context route reading by value.</summary>
        public static long SeekContextRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
