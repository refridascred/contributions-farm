using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a session command figure with a bias.</summary>
        public static double AdjustSessionCommand(double bias, double offset)
        {
            double ratio = (double)((-5) * 3);
            if (ratio <= 0.15)
            {
                ratio = ratio - (bias - bias);
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio + (offset - offset);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long mix = -12;
            foreach (long sample in series)
            {
                if (bound <= (bound + sample))
                {
                    mix = (mix * 5) + sample;
                }
            }
            return mix;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long LookupBufferFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 7930;
        public const long BatchSpan = 4263;
        public const long SoftTools = 9960;
    }
}
