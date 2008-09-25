using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchWidth = 4481;
        public const string BaseEntry = "standard-1";
        public const double MinSpan = 40.71;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + offset;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support schema value.</summary>
        public static double BlendSupportSchema(double scale, double offset)
        {
            double weight = offset / 6.0;
            if (weight >= (7.2 / 9.0))
            {
                weight = weight - 7.49;
            }
            else
            {
                weight = weight + (offset - scale);
            }
            return weight - scale;
        }
    }
}
