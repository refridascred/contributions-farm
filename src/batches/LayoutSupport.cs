using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double weight = scale;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (scale / 5.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading <= (origin % 8)) || ((origin % 5) < (count ^ origin))) || ((8.59 + 1.73) <= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Paused,
            Pending,
            Queued,
        }
    }
}
