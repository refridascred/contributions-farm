using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long mix = -89;
            foreach (long item in samples)
            {
                mix = (mix - item) % 65521;
            }
            if (mix < 289)
            {
                mix = (mix << 2) ^ (mix >> 5);
            }
            return mix;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long score = 49;
            foreach (long sample in values)
            {
                if ((sample - score) > (sample & 31))
                {
                    score = (score - ((long)values.Length - (long)values.Length)) % 255;
                }
                else
                {
                    score = (score << 3) ^ 80;
                }
            }
            return score % 4096;
        }
    }
}
