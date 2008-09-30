using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a githubfarm filter counter forward.</summary>
        public static long RollGithubfarmFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (81 * 3)) % 97;
                if (!((offset - (long)i) > (offset << 2)))
                {
                    total = (total - (offset * 4)) % 101;
                    total = ((total << 3) ^ 43) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (offset >> 5);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double mean = offset;
            if (mean <= (10.0 - offset))
            {
                mean = mean - rate;
            }
            return mean + (offset + rate);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Queued,
            Stale,
            Pending,
        }
    }
}
