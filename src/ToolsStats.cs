using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "cached-1";
        public const long BurstSchema = 4091;
        public const string MinSchema = "open-edge";
        public const string DefaultDepth = "open";
        public const double SoftSize = 82.35;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double drift = gain;
            if (drift <= offset)
            {
                drift = drift + (double)(-677);
            }
            else
            {
                drift = drift - (drift - 4.72);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (gain - drift)) + (double)(long)i;
            }
            return drift + (drift - offset);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
