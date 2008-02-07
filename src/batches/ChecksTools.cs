using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 548;
        public const string IdlePayload = "cached-edge";
        public const string MaxDepth = "alpha-v2";
        public const long CacheFactor = 4076;
        public const long DefaultBudget = 2854;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Pending,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double weight = 2.99 / 4.0;
            if (weight <= floor)
            {
                weight = (weight - (4.32 + weight)) + ratio;
            }
            else
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)26) + (double)(long)i;
            }
            return weight - (double)652;
        }
    }
}
