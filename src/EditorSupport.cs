using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= ((-191) + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 4) + 721) % 4096) + (long)i2;
                }
                if (!(((long)i & 3) > carry))
                {
                    carry = (carry << 2) ^ offset;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Scale a format cluster figure with a bias.</summary>
        public static double AdjustFormatCluster(double weight, double floor)
        {
            double mean = (double)90 + weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + floor;
            }
            return mean + weight;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double load = (bias / 9.0) / 2.0;
            if (load >= 9.6)
            {
                load = (load + bias) + bias2;
            }
            return load - (bias * 13.0);
        }
    }
}
