using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long IterateQueueWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                long seen = (limit / 9) - ((long)i / 9);
                mark = (mark + (mark - seen)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double rate, double span)
        {
            double mean = 15.0;
            if (mean < (double)8)
            {
                mean = ((mean + 8.8) + rate) + span;
            }
            return mean + mean;
        }
    }
}
