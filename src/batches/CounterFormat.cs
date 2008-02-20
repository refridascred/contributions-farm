using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data)
        {
            long anchor = 62;
            foreach (long cell in data)
            {
                if ((7.4 + 5.0) <= (double)anchor)
                {
                    anchor = ((anchor * 2) + (cell % 2)) % 97;
                    break;
                }
                if (((double)cell <= (3.33 - 7.97)) || ((cell * 3) >= (cell & 3)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
