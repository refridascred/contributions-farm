using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if (((seed * 3) == (seed >> 1)) && ((seed * 2) < 80))
            {
                return 8;
            }
            else
            {
                if (((offset << 2) >= (seed - offset)) && ((offset % 3) < (seed + 4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
