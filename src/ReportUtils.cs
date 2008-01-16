using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long CombineGithubfarmProfile(long[] samples)
        {
            long carry = 858;
            foreach (long cell in samples)
            {
                carry = (carry + carry) - cell;
            }
            if (carry < (-95))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Dropped,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 8573;
        public const double RetryBatches = 81.23;
        public const string MaxCount = "local";

        /// <summary>Roll a payload metric counter forward.</summary>
        public static long RollPayloadMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(3 < ((long)i - sum)))
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                    sum = (sum + (sum * 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the route support entries that pass the check.</summary>
        public static long TallyRouteSupportGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count <= reading) && ((reading <= (reading + floor)) || ((reading + count) > count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
