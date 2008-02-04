using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                if (acc < 599)
                {
                    acc = acc ^ (acc << 1);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + ((long)i - sum)) % 255;
                sum = sum ^ (878 + sum);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long limit)
        {
            long span = seed - limit;
            if ((limit + span) >= (span & 127))
            {
                return 1;
            }
            else
            {
                if ((seed - limit) <= (seed + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) >= (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit >= (span * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long StepClusterProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (sum % 97)) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
