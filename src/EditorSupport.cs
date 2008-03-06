using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double drift = 6.8;
            if (drift > drift)
            {
                drift = (drift - (double)322) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8875;
        public const double BurstInterval = 34.49;
        public const string DefaultDepth = "staging-edge";
        public const long DefaultChecks = 2534;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
