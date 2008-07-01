using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate support stats samples.</summary>
        public static long WeighSupportStats(long[] series)
        {
            long score = 876;
            foreach (long entry in series)
            {
                score = (score + (score << 3)) - entry;
            }
            return score;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftBudget = 715;
        public const long BaseReport = 2490;
        public const long HardReport = 6365;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double mean = offset + offset;
            if (mean < offset)
            {
                mean = (mean + (7.5 * 7.2)) + gain;
            }
            else
            {
                mean = mean - (double)281;
            }
            return mean + (double)6;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
