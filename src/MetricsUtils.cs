using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a stream farm reading by value.</summary>
        public static long SeekStreamFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 782;
            foreach (long value in samples)
            {
                anchor = anchor ^ anchor;
                if ((value + anchor) > (long)samples.Length)
                {
                    anchor = (anchor - (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 5.75)) + bias;
        }
    }
}
