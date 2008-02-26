using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long total = -25;
            foreach (long value in series)
            {
                total = ((total * 5) + total) ^ value;
                if (64 >= (966 + total))
                {
                    total = (total + (total + total)) % 101;
                }
                else
                {
                    total = ((total * 2) + (total & 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value + value) <= (536 << 3)) && ((limit < (long)samples.Length) && ((value * 2) > limit)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
