using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((5.09 * 1.18) == (double)bound)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total - ((long)i - total)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if (((mix - value) < (value / 3)) && ((double)value >= (double)mix))
                {
                    mix = mix + (mix << 1);
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a schema already reading by value.</summary>
        public static long FindSchemaAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
