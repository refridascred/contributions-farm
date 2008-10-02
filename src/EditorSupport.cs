using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long step)
        {
            long mark = 398;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 4) + ((long)i % 5)) - entry;
                }
                if (step >= mark)
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate layout session readings against a bound.</summary>
        public static bool GuardLayoutSessionLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + limit) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(3.56 <= (double)seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
