using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardCount = 2491;
        public const long BatchScore = 6721;
        public const string StepQueue = "standard-1";
        public const string SoftLevel = "fallback";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Done,
            Draft,
            New,
        }
    }
}
