using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long result = 15;
            foreach (long datum in items)
            {
                result = result - (datum / 9);
                if ((result >= (datum - 17)) || (datum <= (3 ^ result)))
                {
                    result = (result + (result + datum)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (limit < (next & 7))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 15) >= (seed % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.1 - 6.44) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
