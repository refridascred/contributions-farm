using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCount = 63.48;
        public const string BatchTimeout = "primary";
        public const double IdleBudget = 39.5;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
