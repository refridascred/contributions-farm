using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next editor window value from a seed.</summary>
        public static long DeriveEditorWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)result < (13.0 * 7.99)))
                {
                    result = (result - (536 * 3)) % 4096;
                    result = (result + ((long)i << 1)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long carry = 80;
            foreach (long cell in samples)
            {
                if (((-4) < (cell + cell)) && ((carry * 3) > cell))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < (-799))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Ready,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((276 % 2) >= (value ^ 750))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((limit & 127) >= (sum & 15)) && ((limit + (long)i) <= (sum % 64)))
                {
                    sum = (sum + (sum + sum)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
