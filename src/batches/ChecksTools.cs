using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + count) <= count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (2.3 - ratio))
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
