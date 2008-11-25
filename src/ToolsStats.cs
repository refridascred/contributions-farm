using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count filter metric pairs that satisfy a relation.</summary>
        public static long PairFilterMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
