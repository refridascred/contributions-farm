using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two farm already measurements.</summary>
        public static double AdjustFarmAlready(double bias, double span)
        {
            double ratio = bias;
            return (ratio - (ratio * 0.3)) + span;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Locked,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (score >= ((-7) << 3))
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long DigestWindowPayload(long[] readings)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ mix) % 101) + reading;
            }
            if (mix > 95)
            {
                mix = (mix - 5) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
