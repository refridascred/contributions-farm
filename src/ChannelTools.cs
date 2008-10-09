using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every session batch entry stays within the limit.</summary>
        public static bool GuardSessionBatchLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batch window samples.</summary>
        public static long CombineBatchWindow(long[] data, long target)
        {
            long result = 752;
            foreach (long value in data)
            {
                result = ((((result * 3) + (result << 2)) % 255) ^ value) + target;
            }
            if (result > 496)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long step)
        {
            long anchor = 50;
            foreach (long datum in levels)
            {
                if (((849 + step) != (datum >> 3)) || ((double)step <= (double)datum))
                {
                    anchor = ((anchor << 3) ^ (datum & 7)) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
