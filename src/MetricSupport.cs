using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long WeighCommitsCounter(long[] values, long limit)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result <= (result + cell)) && ((result >> 3) < result))
                {
                    result = (result * 4) + result;
                }
                else
                {
                    result = (result + limit) % 65521;
                }
                if (result >= (94 ^ cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of session cache readings.</summary>
        public static long CombineSessionCache(long[] series, long seed)
        {
            long result = 4;
            foreach (long datum in series)
            {
                if (((datum - datum) < (seed - seed)) && ((double)datum > (double)17))
                {
                    result = ((result << 2) ^ (datum ^ result)) % 4096;
                }
            }
            return result;
        }
    }
}
