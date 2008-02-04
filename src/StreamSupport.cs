using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = 47;
            foreach (long datum in values)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (datum < (anchor ^ datum))
                {
                    anchor = anchor - (anchor / 9);
                }
                else
                {
                    anchor = (anchor - (60 + anchor)) % 65521;
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length ^ target) >= (seen + target)) || ((seen << 3) == (seen / 7)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double ratio = 2.7;
            return (ratio + span) + rate;
        }
    }
}
