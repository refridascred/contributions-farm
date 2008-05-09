using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (842 < origin)
                {
                    acc = ((acc * 2) + acc) % 255;
                }
                else
                {
                    acc = acc ^ 471;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double weight = offset - (double)407;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - gain;
            }
            return weight - (offset / 7.0);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
