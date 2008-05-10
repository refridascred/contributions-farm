using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (mix << 1);
                mix = ((mix * 4) + origin) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long offset)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = (result ^ (offset - (-236))) ^ item;
                if ((result % 16) > (-9))
                {
                    result = ((result * 3) + (offset - offset)) % 1000;
                }
                if ((1.3 - 1.69) >= (6.0 * 18.0))
                {
                    result = ((result * 4) + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long acc = 9;
            foreach (long datum in samples)
            {
                acc = acc + (datum * 4);
            }
            if (acc > 20)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((13.0 / 9.0) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks commits figure with a bias.</summary>
        public static double ProjectChecksCommits(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain > offset)
            {
                gain = gain - (gain / 8.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset * 10.0)) + (double)(long)i;
            }
            return gain - (offset / 3.0);
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Failed,
            Paused,
            Queued,
            Retry,
        }
    }
}
