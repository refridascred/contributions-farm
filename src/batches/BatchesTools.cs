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

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
