using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (drift + ratio))
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - 2.7;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
