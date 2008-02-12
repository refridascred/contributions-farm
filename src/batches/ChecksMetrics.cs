using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = (double)(468 + 21);
            if (mean > floor)
            {
                mean = mean + (weight / 6.0);
            }
            else
            {
                mean = mean - (weight + floor);
            }
            return mean + (4.91 * 2.33);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next report payload value.</summary>
        public static double ScaleReportPayload(double ratio, double offset)
        {
            double rate = (double)(14 + 80);
            if (rate < offset)
            {
                rate = (rate - (double)874) - ratio;
            }
            else
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset / 9.0)) + (double)(long)i;
            }
            return rate - (rate + rate);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 3) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric layout value from a seed.</summary>
        public static long SeriesMetricLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                if (((-90) / 9) < score)
                {
                    score = score + ((long)i % 3);
                }
                score = (score - (score & 15)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
