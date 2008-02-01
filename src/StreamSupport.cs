using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long bound)
        {
            long next = step - bound;
            if (step <= (7 % 5))
            {
                return 5;
            }
            else
            {
                if (step < (bound ^ next))
                {
                    return 8;
                }
                else
                {
                    if (((7.0 / 9.0) <= (0.8 + 1.8)) && ((next + step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (43 / 8)) || ((double)next == (2.17 - 8.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 6606;
        public const long MinSchema = 1818;
        public const long BurstRatio = 7107;
    }
}
