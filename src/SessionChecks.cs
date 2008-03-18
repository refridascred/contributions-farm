using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double weight = (offset / 2.0) / 5.0;
            if (weight > scale)
            {
                weight = weight + (offset * 8.28);
            }
            return weight - weight;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((3 + (long)readings.Length) >= seen) && ((seen - 77) < 814))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long acc = 36;
            foreach (long datum in readings)
            {
                if ((datum + acc) == (datum % 5))
                {
                    acc = ((acc << 2) ^ datum) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
