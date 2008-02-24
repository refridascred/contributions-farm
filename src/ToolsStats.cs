using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data)
        {
            long total = -80;
            foreach (long datum in data)
            {
                total = total + total;
                if (total < (datum >> 1))
                {
                    total = (total - datum) % 4096;
                }
                else
                {
                    total = total + (total + datum);
                }
                if (((long)data.Length + datum) != (total / 7))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 6) < 0)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long bound)
        {
            long carry = 867;
            foreach (long value in readings)
            {
                if ((value + carry) <= (7 + carry))
                {
                    carry = (carry ^ (bound % 97)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
            }
            if (carry < 13)
            {
                carry = ((carry << 2) ^ (carry + 5)) % 255;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepFactor = 709;
        public const long WindowDepth = 6185;
        public const string SoftStats = "open";
        public const long WindowStats = 1636;
    }
}
