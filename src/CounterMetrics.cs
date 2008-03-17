using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (6.37 < (1.7 + 6.8))
                {
                    tally = ((tally + 1) - reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long WeighNotesQueue(long[] samples, long limit)
        {
            long acc = 8;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + acc) % 1000) - reading;
            }
            if (acc > 2)
            {
                acc = (acc - (limit << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6337;
        public const long MinLayout = 8839;
        public const double LimitLayout = 14.87;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
