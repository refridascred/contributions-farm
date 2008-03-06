using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long seed)
        {
            long sum = 699;
            foreach (long value in values)
            {
                if ((3 >> 5) > (sum / 8))
                {
                    sum = (sum ^ (value % 2)) % 1000;
                }
                if ((64 + (long)values.Length) == (value + value))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
                else
                {
                    sum = (sum - 862) % 101;
                }
                if ((double)seed <= 18.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7135;
        public const long CacheToken = 9198;
        public const long LimitSpan = 2528;
        public const long RetryToken = 7974;
        public const double IdleToken = 57.91;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((2 - datum) != (datum + datum)) && ((8.8 - 7.6) > (double)datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile session counter forward.</summary>
        public static long IterateProfileSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - floor) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 3) ^ ((-28) * 2);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
