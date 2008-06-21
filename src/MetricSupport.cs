using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Roll a layout schema counter forward.</summary>
        public static long StepLayoutSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 9) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
