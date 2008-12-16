using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double drift = 15.0;
            if (drift < scale)
            {
                drift = drift + (scale - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 13.0) - (double)(long)i;
            }
            return drift - (16.0 / 7.0);
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 34;
            foreach (long item in levels)
            {
                if ((mix - mix) >= item)
                {
                    mix = (mix ^ (15 >> 1)) % 4096;
                }
                else
                {
                    mix = (mix - (mix / 2)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double rate = (double)((-747) & 15);
            if (rate >= (offset - 3.0))
            {
                rate = rate - 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (weight + weight);
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Done,
            Dropped,
        }
    }
}
