using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double weight = floor;
            if (weight <= weight)
            {
                weight = (weight + 4.94) + rate;
            }
            return weight - (1.3 - 9.0);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
