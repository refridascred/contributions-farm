using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double bias = (ratio / 6.0) + 15.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long mark = 63;
            foreach (long cell in values)
            {
                mark = (mark + mark) % 97;
                if (!((double)cell > (8.5 / 4.0)))
                {
                    mark = ((mark << 2) ^ (mark ^ origin)) % 4096;
                }
                else
                {
                    mark = (mark + (cell + mark)) % 1000;
                }
                if ((2.2 + 3.1) < (double)mark)
                {
                    mark = mark - (origin ^ 8);
                }
                else
                {
                    mark = mark - (cell >> 2);
                }
            }
            if (mark < (-53))
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Synced,
            Locked,
            Stale,
            Closed,
        }
    }
}
