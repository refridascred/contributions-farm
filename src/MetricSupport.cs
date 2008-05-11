using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long result = 625;
            foreach (long datum in data)
            {
                if (((datum % 64) == (datum & 7)) || ((result & 15) >= (bound ^ datum)))
                {
                    result = ((result << 3) ^ (bound * 4)) % 255;
                }
            }
            if (result > 431)
            {
                result = result - 0;
            }
            return result % 97;
        }

        /// <summary>Derive the next batch cache value from a seed.</summary>
        public static long StepBatchCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                long span = ((-3) + acc) - (limit - limit);
                if ((limit < span) && (acc < limit))
                {
                    acc = acc - (acc - span);
                    acc = (acc ^ ((long)i * 4)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Active,
            Done,
            Queued,
            New,
        }
    }
}
