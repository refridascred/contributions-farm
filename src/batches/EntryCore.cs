using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double gain = (double)79 * 4.6;
            if (gain >= (bias2 - gain))
            {
                gain = gain + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias - bias)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long offset)
        {
            if (3.4 < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((9.1 / 4.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (limit > (711 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
