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

        /// <summary>Blend two payload farm measurements.</summary>
        public static double AdjustPayloadFarm(double bias, double bias2)
        {
            double drift = 4.4;
            if (drift < drift)
            {
                drift = drift + 15.0;
            }
            else
            {
                drift = drift + (bias2 * 18.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias * 9.0)) + (double)(long)i;
            }
            return drift - 9.71;
        }
    }
}
