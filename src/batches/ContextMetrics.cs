using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long acc = 43;
            foreach (long sample in series)
            {
                acc = (acc + 71) + sample;
            }
            return acc;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double span)
        {
            double scale = span;
            return scale - (ratio - ratio);
        }

        /// <summary>Look up the position of a session contributi sample.</summary>
        public static long SeekSessionContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long LocateSchemaProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
