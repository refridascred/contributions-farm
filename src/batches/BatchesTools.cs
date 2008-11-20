using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > scale)
            {
                scale = (scale - 1.43) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - 6.4;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data, long step)
        {
            long mark = 1;
            foreach (long item in data)
            {
                mark = ((mark * 3) + (item & 127)) - step;
                if (item >= (long)data.Length)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
