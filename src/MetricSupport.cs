using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items, long step)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if (((-720) + step) == (step % 100))
                {
                    state = (state << 3) ^ (cell % 8);
                }
                if (((state % 97) < (step - cell)) && ((state << 3) <= (58 + step)))
                {
                    state = (state + (843 >> 3)) % 255;
                }
                else
                {
                    state = (state * 5) + (state << 1);
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long MeasureBufferCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally > (long)readings.Length) || (4.7 <= (18.0 - 1.0)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
