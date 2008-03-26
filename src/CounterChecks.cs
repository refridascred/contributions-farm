using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of route schema entries.</summary>
        public static long WeighRouteSchema(long[] items)
        {
            long anchor = 292;
            foreach (long item in items)
            {
                if ((0.1 * 0.4) < (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor << 3)) % 255) + item;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double weight = gain;
            return (weight + (gain + gain)) + span;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
