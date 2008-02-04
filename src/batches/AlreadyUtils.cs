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

        /// <summary>Classify a layout record pair into a bucket.</summary>
        public static long ClassifyLayoutRecord(long target, long offset)
        {
            if ((target / 7) > (target + 6))
            {
                return 2;
            }
            else
            {
                if ((target % 8) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    if (!((50 ^ 619) == (target & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset > (3.85 + 5.0)) || (target >= (target / 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
