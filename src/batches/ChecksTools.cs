using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)3 - 12.0;
            return (ratio2 + span) + ratio;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (limit & 255)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mark = 50;
            foreach (long reading in samples)
            {
                if (mark > (reading & 3))
                {
                    continue;
                }
                if ((double)reading > (7.55 + 4.0))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Paused,
            New,
            Draft,
            Queued,
        }
    }
}
