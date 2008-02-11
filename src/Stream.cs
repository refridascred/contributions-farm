using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (4.86 / 2.0)) + (double)(long)i;
            }
            return scale - (offset / 4.0);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 85.97;
        public const long IdleSize = 4856;
        public const double BaseInterval = 56.17;
    }
}
