using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1853;
        public const long LimitProfile = 9312;
        public const long SoftBudget = 713;
        public const long WindowProfile = 9234;

        /// <summary>Combine record editor values into a single score.</summary>
        public static long DigestRecordEditor(long[] samples, long limit)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if ((limit % 12) >= limit)
                {
                    carry = (carry + (value >> 1)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry + (carry - limit);
            }
            return carry;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((floor - mark) > ((long)i / 6)))
                {
                    mark = mark + (mark + mark);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
