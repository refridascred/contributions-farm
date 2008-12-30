using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight - bias))
            {
                ratio = ratio - (double)262;
            }
            else
            {
                ratio = ratio - (bias * 7.2);
            }
            return ratio + (bias / 2.0);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
