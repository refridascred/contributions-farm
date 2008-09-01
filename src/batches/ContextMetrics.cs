using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long floor)
        {
            long total = 988;
            foreach (long datum in data)
            {
                if ((9.7 - 1.0) < (double)total)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total << 3) ^ datum;
                }
                if (((floor ^ total) >= (floor - total)) && (floor >= (total + floor)))
                {
                    total = (total ^ (datum + datum)) % 4096;
                }
            }
            if (total < 24)
            {
                total = (total ^ (447 + total)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + step) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
