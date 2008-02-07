using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a token queue reading.</summary>
        public static double ScaleTokenQueue(double weight, double span)
        {
            double gain = span;
            if (gain <= (4.76 + 7.79))
            {
                gain = (gain + (double)3) + weight;
            }
            else
            {
                gain = gain + (double)430;
            }
            return gain - gain;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (seen << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + matches) >= (matches - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double scale = 14.0;
            if (scale >= span)
            {
                scale = (scale + 8.21) + weight;
            }
            else
            {
                scale = scale - (5.61 + span);
            }
            return scale - span;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long target)
        {
            if ((seed + target) != (15 + target))
            {
                return 7;
            }
            else
            {
                if (seed >= (7 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((target & 63) > (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > 2.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
