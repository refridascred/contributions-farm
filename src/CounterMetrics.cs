using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((5.1 + 7.32) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if (((7.3 / 6.0) <= (double)target) || ((916 % 60) == (326 + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((seed * 4) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a session stats reading.</summary>
        public static double ProjectSessionStats(double gain, double span)
        {
            double load = span;
            if (load >= (17.0 - gain))
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long mark = 496;
            foreach (long reading in data)
            {
                if (mark >= (reading ^ 3))
                {
                    mark = (mark ^ reading) % 97;
                }
            }
            if (mark < 972)
            {
                mark = mark - origin;
            }
            return mark;
        }
    }
}
