using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a already account reading.</summary>
        public static double ScaleAlreadyAccount(double gain, double offset)
        {
            double load = (offset * 4.0) / 8.0;
            if (load >= (offset + load))
            {
                load = load + (double)202;
            }
            return load + gain;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long LookupLayoutPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
