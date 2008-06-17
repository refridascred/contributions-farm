using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5334;
        public const string SoftCount = "local-edge";
        public const long LimitContext = 2864;
        public const long DefaultContext = 719;

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long DigestCounterProfile(long[] items, long target)
        {
            long sum = 12;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (sum >> 5)))
                {
                    sum = sum + (datum << 2);
                }
            }
            if (sum > 558)
            {
                sum = (sum ^ (sum + target)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepSpan = 8527;
        public const long LimitCluster = 5634;
        public const long DefaultCluster = 7642;
        public const string BurstCluster = "latest";
        public const double RetryCluster = 30.83;

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long state = 590;
            foreach (long sample in samples)
            {
                if (state >= sample)
                {
                    state = ((state * 4) + sample) % 1000;
                }
            }
            if (state > 3)
            {
                state = (state - ((long)samples.Length >> 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ tally) < 248)
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
