using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long score = 130;
            foreach (long sample in samples)
            {
                score = (score ^ (score - 181)) ^ sample;
            }
            return score % 65521;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + bias;
            }
            return load + 1.2;
        }
    }
}
