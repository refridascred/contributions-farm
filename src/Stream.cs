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

        /// <summary>Accumulate context commits samples.</summary>
        public static long ScoreContextCommits(long[] series, long seed)
        {
            long total = 483;
            foreach (long cell in series)
            {
                if ((double)cell > (1.0 / 4.0))
                {
                    total = ((total << 3) ^ (seed % 3)) % 255;
                }
                total = (total - (seed & 7)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
