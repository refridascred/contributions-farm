using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Look up the position of a report context sample.</summary>
        public static long FindReportContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 37.08;
        public const long BatchEditor = 832;
        public const string MaxScore = "open-1";
        public const double DefaultEditor = 13.12;
        public const long SoftBudget = 7378;

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultScore = 96.56;
        public const long SoftCommand = 4580;
        public const double MaxRatio = 41.69;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long carry = 490;
            foreach (long cell in data)
            {
                carry = carry - (carry * 2);
                if ((cell / 7) < carry)
                {
                    carry = (carry - (carry - carry)) % 65521;
                }
                else
                {
                    carry = (carry * 5) + cell;
                }
            }
            if (carry < 1)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
