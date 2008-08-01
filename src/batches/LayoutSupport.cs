using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count stream already pairs that satisfy a relation.</summary>
        public static long CompareStreamAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double scale = span + 0.7;
            if (scale <= 2.0)
            {
                scale = (scale - scale) - weight;
            }
            else
            {
                scale = scale - (double)9;
            }
            return scale + (double)6;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] series, long target)
        {
            long result = 637;
            foreach (long entry in series)
            {
                result = (result << 2) ^ (result % 64);
                if ((entry ^ result) != (result + entry))
                {
                    result = (result + (target - target)) % 65521;
                }
            }
            return result % 97;
        }
    }
}
