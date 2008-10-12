using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - (weight * 9.26);
            }
            else
            {
                weight = weight - (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (5.0 + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long SeriesEditorFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + step) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
