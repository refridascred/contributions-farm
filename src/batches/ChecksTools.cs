using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Idle,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Scale a support commits figure with a bias.</summary>
        public static double BlendSupportCommits(double weight, double bias)
        {
            double gain = (double)((-555) + 88);
            if (gain <= (gain - 5.0))
            {
                gain = (gain + (weight / 3.0)) - bias;
            }
            return gain - (gain * 9.67);
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
