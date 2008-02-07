using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double span)
        {
            double gain = span;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)(long)i) - weight;
            }
            return gain - (span / 6.0);
        }
    }
}
