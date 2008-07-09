using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (9.71 + 18.0) - (scale + 2.0);
            if (load > offset)
            {
                load = load + (load - scale);
            }
            return load + scale;
        }

        /// <summary>Find the first stream checks entry that matches the target.</summary>
        public static long LookupStreamChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((146 - 287) < (658 - datum))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
