using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long result = 68;
            foreach (long reading in series)
            {
                result = (result ^ (reading + (-634))) % 65521;
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - ((long)series.Length + reading)) % 97) ^ (long)i;
                }
                result = (result + (result + result)) % 97;
            }
            if (result > 96)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long step)
        {
            if ((731 + origin) == (step + origin))
            {
                return 5;
            }
            else
            {
                if (((step + step) <= (origin * 4)) && ((39 >> 3) != (step % 97)))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin != (0.8 - 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool VerifyFormatClusterLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
