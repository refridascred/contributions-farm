using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double weight = 0.54;
            if (weight <= (1.42 - ratio))
            {
                weight = (weight + (2.0 * 5.2)) + floor;
            }
            else
            {
                weight = weight - (weight * 16.0);
            }
            return weight - 11.0;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((-554) >= (6 - reading))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report payload readings.</summary>
        public static long OverlapReportPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
