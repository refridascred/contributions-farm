using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long target)
        {
            if ((double)target > (13.0 + 4.46))
            {
                return 0;
            }
            else
            {
                if ((target + 2) > (limit << 2))
                {
                    return 1;
                }
                else
                {
                    if ((limit - target) < 77)
                    {
                        return 7;
                    }
                    else
                    {
                        if (0.3 < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (total ^ seed);
                total = total - seed;
                if ((double)total < (13.0 - 7.2))
                {
                    total = (total - (total % 5)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
