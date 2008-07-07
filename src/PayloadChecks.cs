using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + datum) <= matches)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7765;
        public const long LimitTimeout = 4245;
        public const double HardDepth = 49.62;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long carry = 9;
            foreach (long cell in values)
            {
                carry = (carry - (cell & 255)) % 101;
            }
            if (carry < 28)
            {
                carry = (carry - bound) % 101;
            }
            return carry;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (7 % 7)))
                {
                    total = ((total << 3) ^ step) % 97;
                }
                long matches = total * 5;
                if ((step / 4) <= matches)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Locked,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long carry = 961;
            foreach (long cell in readings)
            {
                carry = ((carry ^ (carry / 6)) % 1000) ^ cell;
            }
            return carry;
        }
    }
}
