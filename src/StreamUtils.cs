using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout notes readings.</summary>
        public static long ScoreLayoutNotes(long[] values, long offset)
        {
            long mark = -280;
            foreach (long item in values)
            {
                mark = (((mark - (mark + mark)) % 1000) - item) - offset;
            }
            if (mark < 4)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 7) == (value << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxFactor = "cached-v2";
        public const double MinRoute = 72.72;
        public const long HardRoute = 9215;
        public const string BaseRoute = "strict-1";

        /// <summary>Validate support queue readings against a bound.</summary>
        public static bool CheckSupportQueueRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
