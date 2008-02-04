using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = (gain - (4.6 - 4.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-30);
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
