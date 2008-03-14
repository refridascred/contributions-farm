using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long result = 52;
            foreach (long value in data)
            {
                if ((result + result) < (value ^ result))
                {
                    result = ((result * 5) + (result + value)) % 97;
                }
                else
                {
                    result = (result - (639 + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((sum + sum) > sum)
                {
                    sum = (sum + (long)i) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
