using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((origin >= (limit + limit)) || ((step ^ step) >= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((double)step > (2.0 - 8.12))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Synced,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (rate - offset))
            {
                scale = scale + (double)16;
            }
            else
            {
                scale = scale + (double)203;
            }
            return scale + (9.0 + rate);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count <= 7.1)
                {
                    count = ((count + 2) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double span)
        {
            double rate = span;
            if (rate < (double)905)
            {
                rate = (rate - span) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 7.5) + (double)(long)i;
            }
            return rate - (span * 16.0);
        }
    }
}
