using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double drift = (double)(82 % 12);
            if (drift < (offset * 7.64))
            {
                drift = (drift + 8.7) - gain;
            }
            return drift + 4.2;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long TallyStreamSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value << 1) < value) || ((double)tally != (5.9 - 4.5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
