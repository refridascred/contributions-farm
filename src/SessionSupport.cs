using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long slot = floor ^ step;
            if ((step + slot) >= (673 * 2))
            {
                return 7;
            }
            else
            {
                if ((floor / 6) != (1 & 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double SmoothFormatWindow(double rate, double offset)
        {
            double gain = rate * 19.0;
            if (gain > rate)
            {
                gain = (gain - (18.0 + rate)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (rate / 4.0)) - (double)(long)i;
            }
            return gain + (rate * 13.0);
        }
    }
}
