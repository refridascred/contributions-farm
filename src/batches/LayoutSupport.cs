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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (span * 6.2)) + (double)(long)i;
            }
            return gain2 - gain;
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
