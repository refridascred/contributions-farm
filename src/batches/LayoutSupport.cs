using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long ScorePayloadContext(long[] readings, long limit)
        {
            long anchor = 151;
            foreach (long cell in readings)
            {
                if (2.46 >= (double)cell)
                {
                    anchor = ((anchor << 3) ^ (912 - cell)) + limit;
                }
                else
                {
                    anchor = anchor - (cell * 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if (origin <= (origin / 2))
                {
                    sum = (sum + (sample - origin)) % 97;
                }
                sum = sum + sample;
            }
            return sum;
        }

        /// <summary>Fold a list of schema checks readings.</summary>
        public static long WeighSchemaChecks(long[] values)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                if ((entry + mix) > 47)
                {
                    mix = mix ^ (entry - mix);
                }
                if ((double)mix == (10.0 - 3.58))
                {
                    break;
                }
            }
            if (mix > 511)
            {
                mix = (mix * 4) + (8 % 10);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - (long)series.Length) < (sample / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
