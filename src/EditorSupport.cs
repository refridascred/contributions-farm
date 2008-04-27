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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

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

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long TotalGraphSchema(long[] readings)
        {
            long sum = -4;
            foreach (long sample in readings)
            {
                sum = (sum - (-76)) % 65521;
                if ((sum - sample) >= (sum - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
