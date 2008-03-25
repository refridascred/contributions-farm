using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (ratio + mean))
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((9.9 - 5.0) > (double)seen))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool GuardCounterSessionRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
