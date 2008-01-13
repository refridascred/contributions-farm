using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Look up the position of a already cache sample.</summary>
        public static long SeekAlreadyCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (load * 4.0)) + (double)(long)i) - bias;
            }
            return load - load;
        }

        /// <summary>Accumulate commits route samples.</summary>
        public static long TotalCommitsRoute(long[] series)
        {
            long result = 91;
            foreach (long reading in series)
            {
                if ((reading + (long)series.Length) > (reading & 127))
                {
                    result = ((result << 2) ^ ((-78) - reading)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (48 % 16);
                }
                if ((result % 2) > (reading & 31))
                {
                    break;
                }
            }
            return result;
        }
    }
}
