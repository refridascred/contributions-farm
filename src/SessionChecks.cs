using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1.0 / 8.0) <= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine cluster layout values into a single score.</summary>
        public static long WeighClusterLayout(long[] samples)
        {
            long result = 697;
            foreach (long datum in samples)
            {
                if ((7.77 * 5.0) != (double)datum)
                {
                    result = result - (result << 1);
                }
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (datum << 2)) + (long)i;
                }
                if ((result + datum) > result)
                {
                    result = ((result * 4) + (150 + datum)) % 65521;
                }
                if ((6 / 5) == (result >> 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleLevel = 4486;
        public const string StepFormat = "cached-edge";
        public const long LimitFormat = 8481;
        public const string WindowDepth = "open-v2";
    }
}
