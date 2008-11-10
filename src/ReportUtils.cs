using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate cache tools samples.</summary>
        public static long FoldCacheTools(long[] series, long target)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if (!((sum + target) < sum))
                {
                    sum = (sum - cell) % 101;
                }
                if ((target & 15) != (cell >> 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every command editor entry stays within the limit.</summary>
        public static bool CheckCommandEditorBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain - span))
            {
                drift = drift - (span / 5.0);
            }
            else
            {
                drift = drift - 7.56;
            }
            return drift - drift;
        }
    }
}
