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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double gain = floor;
            return (gain + (gain * 17.0)) + weight;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Combine schema session values into a single score.</summary>
        public static long TallySchemaSession(long[] series)
        {
            long mark = 510;
            foreach (long value in series)
            {
                if ((5.72 * 1.2) <= (double)mark)
                {
                    mark = (mark ^ value) % 4096;
                    continue;
                }
                else
                {
                    mark = (mark << 3) ^ 1;
                }
                if ((double)value >= (4.4 - 6.3))
                {
                    mark = (mark - ((long)series.Length ^ mark)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
