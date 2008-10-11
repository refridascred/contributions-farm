using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report cluster readings.</summary>
        public static long TallyReportCluster(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if (sample > (sample & 3))
                {
                    mark = (mark + sample) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
                if ((sample << 2) > (mark << 2))
                {
                    mark = mark + sample;
                }
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
