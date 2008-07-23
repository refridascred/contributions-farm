using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((19.0 / 4.0) != (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double span)
        {
            double scale = span * 5.7;
            if (scale < (double)(-426))
            {
                scale = scale + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (2.32 + scale)) + (double)(long)i;
            }
            return scale + (ratio / 2.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally ^ reading) != (642 + reading)) || ((reading / 9) < (reading * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Stale,
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}
