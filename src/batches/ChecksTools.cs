using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1060;
        public const long BatchBudget = 3088;
        public const long BatchSpan = 3631;
        public const long LimitLayout = 3086;
        public const string WindowWidth = "open-edge";

        /// <summary>Scale a layout order figure with a bias.</summary>
        public static double ProjectLayoutOrder(double gain, double span)
        {
            double gain2 = span;
            return (gain2 + span) + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 9920;
        public const long BatchReport = 5670;
        public const long LimitInterval = 2507;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Paused,
            Done,
        }
    }
}
