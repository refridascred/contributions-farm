using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double load = rate;
            if (load <= rate)
            {
                load = load + (span / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long SeekSchemaCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
