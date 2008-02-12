using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading >> 1) > reading)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                if ((total ^ seed) >= 323)
                {
                    total = ((total * 3) + cell) % 1000;
                }
                if (((double)cell < (double)total) || ((seed - (long)readings.Length) < (cell + total)))
                {
                    break;
                }
            }
            if (total > 506)
            {
                total = (total << 3) ^ (seed + seed);
            }
            return total % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
