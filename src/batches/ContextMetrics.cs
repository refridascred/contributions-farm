using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long result = 478;
            foreach (long value in items)
            {
                if ((double)result >= (8.6 + 1.3))
                {
                    result = result + (value >> 4);
                }
            }
            if (result < 81)
            {
                result = result + (result % 12);
            }
            return result;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long TallyBufferSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen >= (8.32 - 7.0))
                {
                    seen = ((seen + 1) - value) - bound;
                }
            }
            return seen;
        }
    }
}
