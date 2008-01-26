using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Done,
            Active,
            Locked,
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double ProjectBufferChannel(double gain, double span)
        {
            double weight = (double)(959 / 4);
            if (weight <= weight)
            {
                weight = ((weight - (weight / 9.0)) + gain) - span;
            }
            return weight + (double)(-57);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Ready,
            Retry,
            Draft,
            New,
        }
    }
}
