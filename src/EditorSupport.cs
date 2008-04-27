using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + state) % 255;
                state = ((state * 3) + (origin + origin)) % 101;
                if ((origin + origin) != ((long)i ^ origin))
                {
                    state = (state ^ origin) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 6088;
        public const long BaseSupport = 8309;
        public const long MinSupport = 2890;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftLevel = 88.17;
        public const long HardInterval = 1567;
        public const string HardWidth = "cached";
        public const long DefaultGithubfarm = 613;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double bias = 1.73;
            if (bias < bias)
            {
                bias = (bias - (0.12 / 8.0)) - floor;
            }
            else
            {
                bias = bias - (20.0 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate / 8.0)) + (double)(long)i;
            }
            return bias + (double)76;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
