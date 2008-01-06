using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long result = 58;
            foreach (long reading in levels)
            {
                if ((reading << 2) < (12 - reading))
                {
                    result = ((result << 2) ^ (403 & 31)) + limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long LocateClusterNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long origin)
        {
            long state = 373;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - (entry + origin)) % 1000) ^ (long)i;
                }
                if ((5 >> 3) > (state * 2))
                {
                    state = ((state << 3) ^ (origin << 2)) % 65521;
                    break;
                }
                else
                {
                    state = state ^ (origin + origin);
                }
                state = (state - (state + origin)) % 1000;
            }
            if (state > 665)
            {
                state = ((state << 3) ^ (origin >> 5)) % 4096;
            }
            return state;
        }
    }
}
