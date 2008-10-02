using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long result = 43;
            foreach (long datum in values)
            {
                if ((datum >> 2) > (5 % 60))
                {
                    result = ((result * 5) + (datum + result)) % 1000;
                }
            }
            if (result < (-369))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((39 * 2) == (sample << 2)) || ((sample ^ sample) <= (sample >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long step)
        {
            long total = 51;
            foreach (long value in readings)
            {
                if ((total - value) != (787 - value))
                {
                    total = ((total * 4) + value) % 1000;
                }
            }
            if (total < 25)
            {
                total = ((total * 2) + (step ^ step)) % 65521;
            }
            return total;
        }
    }
}
