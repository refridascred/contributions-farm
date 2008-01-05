using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two cluster githubfarm measurements.</summary>
        public static double SmoothClusterGithubfarm(double gain, double offset)
        {
            double drift = offset / 8.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (17.0 + drift)) + (double)(long)i) + gain;
            }
            return drift - (double)86;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            New,
            Done,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long carry = 74;
            foreach (long reading in readings)
            {
                carry = (carry + (reading + carry)) % 101;
                if ((reading - carry) >= carry)
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
