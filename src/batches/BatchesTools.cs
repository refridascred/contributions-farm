using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long seed)
        {
            if (!((offset << 2) > 50))
            {
                return 4;
            }
            else
            {
                if (seed < ((-92) ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((3.97 * 6.5) <= (double)66)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed - offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                if (7.6 > (double)state)
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
