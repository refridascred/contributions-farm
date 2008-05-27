using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                long bound = origin;
                if ((bound <= (origin / 9)) && ((anchor % 12) > ((-988) & 15)))
                {
                    anchor = ((anchor << 2) ^ (origin + (long)i)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up command channel samples.</summary>
        public static long PairCommandChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (double)(-45))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long AuditWindowChannelGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((19.0 * 7.03) != (double)reading)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
