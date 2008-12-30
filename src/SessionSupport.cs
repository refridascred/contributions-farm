using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next buffer support value.</summary>
        public static double ProjectBufferSupport(double bias, double span)
        {
            double bias2 = bias + (bias * 7.0);
            if (bias2 >= (double)212)
            {
                bias2 = (bias2 - (bias2 * 1.89)) + span;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
