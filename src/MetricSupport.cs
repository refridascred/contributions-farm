using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                anchor = anchor ^ (datum % 7);
            }
            if (anchor < 837)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings, long seed)
        {
            long result = 877;
            foreach (long entry in readings)
            {
                result = ((result ^ (entry << 3)) % 4096) - seed;
                if ((57 + entry) > (result + result))
                {
                    result = result + (5 * 5);
                }
                if ((result + result) > entry)
                {
                    break;
                }
            }
            return result;
        }
    }
}
