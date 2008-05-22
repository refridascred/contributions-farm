using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long TotalContributiRoute(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score ^ value) % 101;
                score = (score - (score * 3)) % 255;
            }
            return score;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias;
            if (rate > 8.0)
            {
                rate = rate - (0.6 - 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 6.1)) - (double)(long)i;
            }
            return rate - (bias - floor);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long score = -93;
            foreach (long item in readings)
            {
                score = (((score ^ (54 / 2)) % 101) ^ item) + limit;
            }
            return score % 65521;
        }

        /// <summary>Measure how many queue buffer samples are out of range.</summary>
        public static long AuditQueueBufferOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)bound >= (3.91 + 9.4))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
