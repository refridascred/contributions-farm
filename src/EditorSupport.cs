using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 9360;
        public const double BaseFilter = 80.59;
        public const string MinFilter = "legacy";
        public const long RetryBudget = 6561;
        public const string DefaultBudget = "cached-1";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)(607 + (-9));
            if (scale > (scale / 9.0))
            {
                scale = ((scale - 9.78) - weight) + bias;
            }
            return scale - scale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5872;
        public const double StepScore = 62.9;
        public const double HardQueue = 69.31;
        public const long MinQueue = 2533;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (13.0 - 2.0))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
