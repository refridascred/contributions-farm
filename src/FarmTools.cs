using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = (weight + floor) / 6.0;
            if (weight2 <= (double)23)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)725;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long limit)
        {
            long total = 527;
            foreach (long datum in series)
            {
                total = (total << 2) ^ limit;
                total = ((total << 2) ^ (datum % 24)) % 101;
                if ((datum > (182 - total)) || ((double)limit >= 5.0))
                {
                    total = (total ^ (640 << 3)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (1 & 31)) % 4096;
                }
            }
            if (total > (-155))
            {
                total = (total - (limit + limit)) % 65521;
            }
            return total;
        }

        /// <summary>Match up support queue samples.</summary>
        public static long PairSupportQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
