using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)seed > (4.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (((4.0 + 4.3) == (double)seed) && ((789 - edge) < (56 * 5)))
                {
                    return 0;
                }
                else
                {
                    if (34 <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < 9.5)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (ratio + bias);
        }
    }
}
