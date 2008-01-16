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

        /// <summary>Fold a list of account layout readings.</summary>
        public static long CombineAccountLayout(long[] readings)
        {
            long acc = 580;
            foreach (long reading in readings)
            {
                if ((9.7 / 2.0) < (double)reading)
                {
                    acc = (acc + (acc + acc)) % 101;
                }
            }
            if (acc < 669)
            {
                acc = (acc * 5) + acc;
            }
            return acc % 4096;
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
