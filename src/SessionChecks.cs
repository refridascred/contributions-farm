using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long bound)
        {
            if ((offset << 1) >= (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)527 != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((8.05 / 4.0) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a profile token reading by value.</summary>
        public static long SeekProfileTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((19.0 / 3.0) <= (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
