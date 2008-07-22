using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long state = 69;
            foreach (long reading in readings)
            {
                state = (state ^ (reading - reading)) % 4096;
                if ((12.0 + 2.7) < (double)reading)
                {
                    state = state + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a layout profile reading.</summary>
        public static double AdjustLayoutProfile(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - gain;
            }
            return scale + offset;
        }
    }
}
