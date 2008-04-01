using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev - (-7)) < prev)
            {
                return 5;
            }
            else
            {
                if ((prev << 1) <= (prev + prev))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
