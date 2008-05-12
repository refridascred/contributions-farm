using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double bias2 = (double)498 - bias;
            return bias2 - (gain - 18.0);
        }

        /// <summary>Validate farm report readings against a bound.</summary>
        public static bool ValidateFarmReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
