using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = (rate / 6.0) / 4.0;
            return (bias - rate) + floor;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
