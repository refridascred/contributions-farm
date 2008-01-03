using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long seed)
        {
            if ((2.0 - 20.0) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset >> 4) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long target)
        {
            long result = 98;
            foreach (long reading in values)
            {
                if (!((result ^ result) >= (reading * 5)))
                {
                    result = (result ^ (reading / 4)) % 255;
                }
                if ((31 >> 4) >= (96 ^ target))
                {
                    result = (result - (reading - reading)) % 1000;
                }
                else
                {
                    result = result + reading;
                }
            }
            return result % 65521;
        }
    }
}
