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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((double)seen >= (double)seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
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
