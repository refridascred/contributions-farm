using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8361;
        public const double DefaultFormat = 21.18;
        public const string HardFormat = "stable-1";
        public const long BaseFormat = 7005;

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6797;
        public const long SoftCount = 2754;
        public const long IdleNotes = 3340;
        public const string WindowNotes = "fallback-1";

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 5812;
        public const long MinContributi = 3635;
        public const double BatchBudget = 81.61;
        public const long LimitSpan = 8739;
    }
}
