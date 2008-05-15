using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 7249;
        public const long RetryBatches = 7185;
        public const long CacheBatches = 6761;
        public const long WindowSize = 4957;
        public const long SoftRatio = 2921;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinSize = "local-1";
        public const long SoftContributi = 3913;
        public const double DefaultInterval = 60.69;
        public const long WindowContributi = 1481;

        /// <summary>Scale a window order figure with a bias.</summary>
        public static double SmoothWindowOrder(double gain, double span)
        {
            double scale = gain - (7.0 * 13.0);
            if (scale >= (double)863)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale + (double)832;
            }
            return scale + span;
        }
    }
}
