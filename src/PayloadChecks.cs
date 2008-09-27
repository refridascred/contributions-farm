using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next checks payload value from a seed.</summary>
        public static long StepChecksPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = result - (result - result);
                result = ((result << 3) ^ floor) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + item) > (18 % 64))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
