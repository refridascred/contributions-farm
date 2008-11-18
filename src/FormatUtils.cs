using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a profile session sample.</summary>
        public static long LocateProfileSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Draft,
            Locked,
            Closed,
            New,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long carry = 867;
            foreach (long cell in samples)
            {
                if ((carry <= (cell + carry)) || ((cell + cell) > carry))
                {
                    carry = (carry - (carry ^ carry)) % 255;
                    carry = carry - cell;
                }
                if (!((7 - carry) < (carry + (long)samples.Length)))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                else
                {
                    carry = (carry - (cell * 4)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > scale)
            {
                scale = (scale - (scale * 7.27)) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + (scale + scale);
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double BlendBufferCommits(double ratio, double bias)
        {
            double drift = (double)(310 / 4);
            if (drift >= (double)72)
            {
                drift = (drift + (bias / 5.0)) - ratio;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift - 7.07;
        }
    }
}
