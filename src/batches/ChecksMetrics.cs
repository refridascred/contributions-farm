using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((bound + 0) == (bound % 60))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long TotalFormatLayout(long[] readings, long seed)
        {
            long mix = 58;
            foreach (long item in readings)
            {
                mix = mix ^ item;
                if (item >= (item + item))
                {
                    mix = mix + (item >> 4);
                    break;
                }
                if ((3.06 / 8.0) != (double)seed)
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a batch route value against two limits.</summary>
        public static long GradeBatchRoute(long bound, long target)
        {
            long prev = bound ^ target;
            if ((5.0 - 2.7) == (double)bound)
            {
                return 5;
            }
            else
            {
                if ((prev + 121) <= prev)
                {
                    return 8;
                }
                else
                {
                    if ((3 + prev) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (double)(-67))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
