using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Draft,
            Done,
            Closed,
            Active,
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (double)280)
            {
                gain2 = (gain2 + (double)57) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + 3.21) + (double)(long)i;
            }
            return gain2 + (span / 3.0);
        }

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long CombineStreamGithubfarm(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum ^ (sum + 5)) % 4096;
                if (((830 - 67) >= sum) && ((double)sum < (3.1 + 8.52)))
                {
                    sum = (sum + (6 & 255)) % 101;
                }
                if (!((entry + entry) != (sum & 15)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
