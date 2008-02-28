using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of payload metric readings.</summary>
        public static long FoldPayloadMetric(long[] data, long origin)
        {
            long result = 6;
            foreach (long cell in data)
            {
                if (((origin + result) >= origin) || ((cell - 98) > (result + origin)))
                {
                    result = (result ^ origin) % 4096;
                }
            }
            if (result < 79)
            {
                result = ((result << 2) ^ ((long)data.Length * 4)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double scale = (weight + 2.2) - (double)7;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (scale * 20.0)) + (double)(long)i) - offset;
            }
            return scale - (double)7;
        }
    }
}
