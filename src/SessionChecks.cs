using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 92.99;
        public const string MinTools = "standard-edge";
        public const long IdleSize = 7014;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Done,
            Dropped,
            Locked,
        }
    }
}
