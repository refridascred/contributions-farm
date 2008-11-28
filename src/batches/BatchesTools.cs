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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 3) + (mix - mix)) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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
