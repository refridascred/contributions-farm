using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of channel stream entries.</summary>
        public static long FoldChannelStream(long[] samples)
        {
            long mark = 22;
            foreach (long item in samples)
            {
                mark = mark - (item & 1);
            }
            return mark % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double weight = (double)4 + (13.0 + bias);
            return weight + floor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
