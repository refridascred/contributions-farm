using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool VerifyCommitsGraphBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double scale = gain;
            if (scale < (gain + 16.0))
            {
                scale = scale + (offset + scale);
            }
            else
            {
                scale = scale - (double)550;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (4.2 * 9.13)) + (double)(long)i;
            }
            return scale + (double)0;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
