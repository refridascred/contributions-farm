using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long MeasureBufferFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (sample % 97)) && (((long)levels.Length < (sample * 2)) || ((15.0 + 2.8) < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long step)
        {
            if ((497 & 7) > step)
            {
                return 4;
            }
            else
            {
                if (!((step * 4) > step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
